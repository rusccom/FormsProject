using FormsProject.Controls;
using FormsProject.Forms.Reports;
using FormsProject.Forms.Service;
using FormsProject.Print;
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
    public partial class DocumentsView : BaseForm
    {
        TableView tvResult = new TableView();

        public DocumentsView()
        {
            InitializeComponent();
        }

        protected void InitBaseFunction(TableView tableView)
        {
            tableView.CellMouseDoubleClick += TvResult_CellMouseDoubleClick;
            tvResult = tableView;
            InitTableFunction();

            DocumentViewReportGenerator documentViewReportGenerator = new DocumentViewReportGenerator();
            documentViewReportGenerator.AddOtherTableSettibg(tvResult, OperationCode);
        }

        protected void InitTableFunction()
        {
            tvResult.AllowUserToAddRows = false;
            tvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        virtual public void RefreshTable()
        {
        }

        private void DocumentsView_Load(object sender, EventArgs e)
        {

        }

        protected bool IsListDocument()
        {
            bool result = false;

            switch (OperationCode)
            {
                case Operations.OperationCode.LIST_MONEY_IN:
                    result = true;
                    break;
                case Operations.OperationCode.LIST_MONEY_OUT:
                    result = true;
                    break;
                case Operations.OperationCode.LIST_PRODUCT_IN:
                    result = true;
                    break;
                case Operations.OperationCode.LIST_PRODUCT_OUT:
                    result = true;
                    break;
            }

            return result;
        }

        public virtual void OpenFilledForm(TableView table = null)
        {
            DataGridViewSelectedRowCollection selectedRows = table.SelectedRows;
            if (selectedRows.Count > 0 && selectedRows.Count < 2)
            {
                int id = (int)selectedRows[0].Cells["id"].Value;
                Operations.OperationCode operationFormCode = Operations.Operation.GetOperationFormCodeByList(OperationCode);
                BaseForm form = FormManager.OpenForm(operationFormCode, id);
                if (form != null)
                {
                    form.FormClosed -= Form_FormClosed;
                    form.FormClosed += Form_FormClosed;
                }
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshTable();   
        }

        private void TvResult_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OpenFilledForm();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Operations.OperationCode operationFormCode = Operations.Operation.GetOperationFormCodeByList(OperationCode);
            BaseForm form = FormManager.OpenForm(operationFormCode);
            form.FormClosed -= Form_FormClosed;
            form.FormClosed += Form_FormClosed;
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            OpenFilledForm();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (tvResult.SelectedRows.Count != 0)
            {
                switch (MessageBox.Show("Вы действительно хотите удалить выделеную строку?", "Удалени записи.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.Yes:
                        if (tvResult.SelectedRows.Count < 2)
                        {
                            int idDocument = (int)tvResult.SelectedRows[0].Cells["id"].Value;
                            Operations.OperationCode operationCodeTable = Operations.Operation.GetOperationFormCodeByList(OperationCode);
                            if (SqlAdapter.SqlQueryAdapter.DeleteRowById(idDocument, operationCodeTable))
                            {
                                MessageBox.Show("Строка успешно удалена.", "Успешное завершение.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshTable();
                            }
                            else
                            {
                                MessageBox.Show("Не удалось удалить выделеную строку.", "Удаление.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Удаление нескольких строк одновременно невозможно.", "Выберети строку.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }
            }
        }

        public virtual void SetFilter()
        {
            userFilter.SetFilter(tvResult, OperationCode);
        }

        private void tstbFiltr_KeyUp(object sender, KeyEventArgs e)
        {
            //if (IsListDocument())
            //{
            //    if (tvResult.Columns.Contains("CustomerId"))
            //        SetFilter("CustomerId like " + "'%" + tstbFiltr.Text + "%'");
            //}
            //else
            //{
            //    if (tvResult.Columns.Contains("name"))
            //        SetFilter("name like " + "'%" + tstbFiltr.Text + "%'");
            //}
            userFilter.TextBoxValue = tstbFiltr.Text;
            SetFilter();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            AppInstance.FormsCollection.Remove(OperationCode);
            base.OnFormClosed(e);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            switch(OperationCode)
            {
                case Operations.OperationCode.LIST_TMC:
                    SavePrice savePrice = new SavePrice();
                    savePrice.Save();
                    break;
            }
        }
    }
}
