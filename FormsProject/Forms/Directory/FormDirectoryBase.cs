using DataProject.TempTable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms
{
    public partial class FormDirectoryBase : BaseForm
    {
        private bool isNewForm = false;
        private bool closeForm = false;
        private int documentId;

        List<Control> formControls = new List<Control>();

        public FormDirectoryBase()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> GetRow(int id)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            result = SqlAdapter.SqlQueryAdapter.GetRowbyId(OperationCode, id);
            return result;
        }

        public virtual void LoadForm(int recordId = 0)
        {
            documentId = recordId;
            formControls = new List<Control>();
            GetControls(this);

            if (documentId != 0)
            {
                FillForm();
                isNewForm = false;
            }
            else
            {
                isNewForm = true;
                foreach (Control control in formControls)
                {
                    switch (control.GetType().ToString())
                    {
                        case "FormsProject.Controls.TableView":
                            ResultTableInit(control);
                            break;
                    }
                }
            }
        }

        private void FillForm()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data = GetRow(documentId);

            foreach (Control control in formControls)
            {
                string qwe = control.GetType().ToString();
                switch (control.GetType().ToString())
                {
                    case "FormsProject.Controls.DataTextBox":
                        FormsProject.Controls.DataTextBox dataTextBox = ((FormsProject.Controls.DataTextBox)(control));
                        if (dataTextBox.FieldName != null)
                        {
                            dataTextBox.Text = data[TrimKey(dataTextBox.FieldName)];
                        }
                        break;

                    case "FormsProject.Controls.DataComboBox":
                        FormsProject.Controls.DataComboBox dataComboBox = ((FormsProject.Controls.DataComboBox)(control));
                        if (!dataComboBox.ReadOnlyControl)
                        {
                            dataComboBox.SelectedValue = Convert.ToInt32(data[TrimKey(dataComboBox.FieldName)]);
                            dataComboBox.Modified = false;
                        }
                        break;

                    case "System.Windows.Forms.CheckBox":
                        System.Windows.Forms.CheckBox checkBox = ((System.Windows.Forms.CheckBox)(control));
                        if (checkBox.Tag != null)
                        {
                            string checkBoxKey = TrimKey(checkBox.Tag.ToString());
                            byte byteData = Convert.ToByte(data[checkBoxKey]);
                            checkBox.Checked = Convert.ToBoolean(byteData);
                        }
                        break;

                    case "System.Windows.Forms.DateTimePicker":
                        System.Windows.Forms.DateTimePicker dateTimePicker = ((System.Windows.Forms.DateTimePicker)(control));
                        string datekey = TrimKey(dateTimePicker.Tag.ToString());
                        dateTimePicker.Value = Convert.ToDateTime(data[datekey]);
                        break;

                    case "FormsProject.Controls.TableView":
                        ResultTableInit(control);
                        break;
                }
            }

        }

        private void ResultTableInit(Control control)
        {
            FormsProject.Controls.TableView tableView = ((FormsProject.Controls.TableView)(control));

            if (tableView.Tag != null)
            {
                HandleItemTable(tableView);
            }
        }

        private string TrimKey(string key)
        {
            return key.Trim(new char[] { '[', ']' });
        }

        private void HandleItemTable(FormsProject.Controls.TableView table)
        {
            Operations.OperationCode documentListOperation = Operations.Operation.GetDocumentItemListOperation(OperationCode);

            string where = "where DocumentId = " + documentId.ToString();
            table.CreateTtable(documentListOperation, where);
        }

        private void GetControls(Control control)
        {
            Control innerControl = control;

            foreach (Control cont in innerControl.Controls)
            {
                GetControls(cont);
            }

            formControls.Add(innerControl);
        }

        private string GenerateDocumentCode(FormsProject.Controls.DataTextBox dataTextBox)
        {
            string result = dataTextBox.GetData();
            switch (dataTextBox.FieldName)
            {
                case "[code]":
                    if (result == "''")
                    {
                        result = "'" + Operations.Operation.GetDocumentCodeByOperationCode(OperationCode) + "'";
                    }
                    break;
            }
            return result;
        }

        protected bool ApplyControlsData()
        {
            bool isSuccess = false;

            Dictionary<string, string> fieldValueData = new Dictionary<string, string>();

            foreach (Control control in formControls)
            {
                string qwe = control.GetType().ToString();
                switch (control.GetType().ToString())
                {
                    case "FormsProject.Controls.DataTextBox":
                        FormsProject.Controls.DataTextBox dataTextBox = ((FormsProject.Controls.DataTextBox)(control));

                        string value = GenerateDocumentCode(dataTextBox);
                        if (dataTextBox.FieldName != null && dataTextBox.IsDataCorrect)// && dataTextBox.Modified)
                        {
                            fieldValueData.Add(dataTextBox.FieldName, value);
                        }
                        break;

                    case "FormsProject.Controls.DataComboBox":
                        FormsProject.Controls.DataComboBox dataComboBox = ((FormsProject.Controls.DataComboBox)(control));
                        if (!dataComboBox.ReadOnlyControl)
                        {
                            string intValue = dataComboBox.SelectedValue.ToString();
                            //if (dataComboBox.Modified)
                            //{
                            fieldValueData.Add(dataComboBox.FieldName, intValue);
                            //}
                        }
                        break;

                    case "System.Windows.Forms.CheckBox":
                        System.Windows.Forms.CheckBox checkBox = ((System.Windows.Forms.CheckBox)(control));

                        if (checkBox.Tag != null)
                        {
                            string tagControl = checkBox.Tag.ToString();
                            fieldValueData.Add(tagControl, Convert.ToByte(checkBox.Checked).ToString());
                        }

                        break;

                    case "System.Windows.Forms.DateTimePicker":
                        System.Windows.Forms.DateTimePicker dateTimePicker = ((System.Windows.Forms.DateTimePicker)(control));
                        fieldValueData.Add(dateTimePicker.Tag.ToString(), "'" + dateTimePicker.Value.ToString() + "'");
                        break;


                }
            }
            if (fieldValueData.Count != 0)
            {
                if (isNewForm)
                {
                    Tuple<int, bool> result = SqlAdapter.SqlQueryAdapter.InsertSQLData(fieldValueData, OperationCode);
                    documentId = result.Item1;
                    isSuccess = result.Item2;
                    if (isSuccess)
                    {
                        TempTableHandler.SetValueToTempTable(AppInstance.UserId, documentId, (int)OperationCode, AppInstance.sqlConnection);
                    }
                }
                else
                {
                    isSuccess = SqlAdapter.SqlQueryAdapter.UpdateRow(fieldValueData, documentId, OperationCode);
                }

                if (isSuccess)
                {
                    foreach (Control control in formControls)
                    {
                        string qwe = control.GetType().ToString();
                        switch (control.GetType().ToString())
                        {
                            case "FormsProject.Controls.TableView":
                                SaveItemTable(control);
                                break;
                        }
                    }
                }
            }
            else
            {
                if (isNewForm)
                {
                    MessageBox.Show("Данные не введены", "Заполните форму.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Close();
                }
            }
            return isSuccess;
        }

        private void SaveItemTable(Control control)
        {
            FormsProject.Controls.TableView tableView = ((FormsProject.Controls.TableView)(control));

            if (tableView.Tag != null)
            {
                Operations.OperationCode documentListOperation = Operations.Operation.GetDocumentItemListOperation(OperationCode);
                SaveTableDocumentItem.SaveDocumentItem(tableView.GetDataTable, documentListOperation, documentId);
            }
        }

        private bool InitApplyData()
        {
            bool result = false;
            if (ApplyControlsData())
            {
                //MessageBox.Show("Данные сохранены.", "Сохранение данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            }
            else
            {
                MessageBox.Show("Данные не сохранены. Проверте корректность данных.", "Сохранение данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (InitApplyData())
            {
                closeForm = true;
                Close();
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (InitApplyData())
            {
                LoadForm(documentId);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!closeForm)
            {
                switch (MessageBox.Show("Вы действительно хотите закрыть окно?", "Окно закрывается.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                }
            }

            base.OnClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (documentId > 0)
            {
                TempTableHandler.DeleteValueFromTempTable(AppInstance.UserId, documentId, (int)OperationCode, AppInstance.sqlConnection);
            }

            base.OnFormClosed(e);
        }
    }
}
