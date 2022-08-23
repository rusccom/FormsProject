using DataProject.SqlDataBase;
using FormsProject.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.BaseSelection
{
    public partial class FormBaseSelection : Form
    {
        public SqlConnection connection;

        private ListInfo dataBaseInfo;

        public FormBaseSelection()
        {
            InitializeComponent();
            lbDataBase.SelectedIndexChanged += LbDataBase_SelectedIndexChanged;
            Fill();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void LbDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDataBase.SelectedItem != null)
            {
                DataBaseInfo info = (DataBaseInfo)lbDataBase.SelectedItem;

                lDataBase.Text = info.DataBase;
                lDataServer.Text = info.Server;
                lbDataBase.Sorted = false;
            }
        }

        private void Fill()
        {
            dataBaseInfo = SerializationDBInfo.GetInfo();
            if(dataBaseInfo != null)
            {
                dataBaseInfo.Update = false;
                
                lbDataBase.DataSource = dataBaseInfo;
                lbDataBase.DisplayMember = "Name";
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            FormAddNewDataBase formAdd = new FormAddNewDataBase();
            switch(formAdd.ShowDialog())
            {
                case DialogResult.OK:
                    DataBaseInfo dataInfo = new DataBaseInfo() { DataBase = formAdd.tbBase.Text, Name = formAdd.tbName.Text, Password = formAdd.tbPass.Text, Server = formAdd.tbServer.Text };
                    dataBaseInfo.Add(dataInfo);
                    dataBaseInfo.Update = true;
                    lbDataBase.SelectedItem = dataInfo;
                    break;
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (lbDataBase.SelectedItem != null)
            {
                DataBaseInfo info = (DataBaseInfo)lbDataBase.SelectedItem;

                FormAddNewDataBase formAdd = new FormAddNewDataBase();
                formAdd.tbBase.Text = info.DataBase;
                formAdd.tbName.Text = info.Name;
                formAdd.tbPass.Text = info.Password;
                formAdd.tbServer.Text = info.Server;

                switch (formAdd.ShowDialog())
                {
                    case DialogResult.OK:
                        DataBaseInfo dataInfo = new DataBaseInfo() { DataBase = formAdd.tbBase.Text, Name = formAdd.tbName.Text, Password = formAdd.tbPass.Text, Server = formAdd.tbServer.Text };
                        int index = dataBaseInfo.IndexOf(info);
                        dataBaseInfo.Remove(info);
                        dataBaseInfo.Insert(index, dataInfo);
                        dataBaseInfo.Update = true;
                        lbDataBase.SelectedItem = dataInfo;
                        break;
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (lbDataBase.Items.Count > 0 && lbDataBase.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить базу из списка?", "Удаление.", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DataBaseInfo info = (DataBaseInfo)lbDataBase.SelectedItem;
                    dataBaseInfo.Remove(info);
                    dataBaseInfo.Update = true;
                }
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            Effect.WaitForm(this, true);
            Task task = new Task(GetConnection);
            task.Start();
        }

        private string GeneratedCreadedDBScript(string dbName)
        {
            string result = string.Empty;

            result = File.ReadAllText(Application.StartupPath + "/SqlQuery/System/CreateNewDataBase.txt", Encoding.Default);
            result = result.Replace("#TableName#", dbName);

            return result;
        }

        private bool IsDataBaseExist(string dbName)
        {
            bool result = false;

            connection = Connection.Open("server=(local); Trusted_Connection=yes");

            switch(connection.State)
            {
                case ConnectionState.Open:
                    result = DataProject.Scripts.SimpleQuery.IsDBExist(dbName, connection);
                    break;
            }

            return result;
        }

        private bool HandlerDataBase(string dbName)
        {
            bool result = true;

            try
            {
                bool dbExist = IsDataBaseExist(dbName);

                if (!dbExist)
                {
                    DialogResult dialogResult = MessageBox.Show($"База данных {dbName} не найдена, создать новую? ", "База данных не найдена.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            string crDBScr = GeneratedCreadedDBScript(dbName);
                            if (!string.IsNullOrEmpty(crDBScr))
                            {
                                DataProject.Scripts.SelectQuery.GetSelect(crDBScr, connection);
                                //DataProject.Scripts.SimpleQuery.CraeteDataBase(crDBScr, connection);
                                connection.Close();
                            }
                            else
                            {
                                MessageBox.Show("Невозможно создать новую базу данных", "Файл для создания базы данных не найден или поврежден.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                result = false;
                            }
                            break;

                        default:
                            result = false;
                            break;
                    }
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }

            return result;
        }

        private void GetConnection()
        {
            if (dataBaseInfo != null && lbDataBase.SelectedItem != null)
            {
                DataBaseInfo info = (DataBaseInfo)lbDataBase.SelectedItem;

                if (HandlerDataBase(info.Name))
                {

                    string connectionString = ConnectionStrBuild.GetString(info);
                    connection = Connection.Open(connectionString);

                    if (connection.State == ConnectionState.Open)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        Log.LogAssistant.SetException(Connection.exception);
                        MessageBox.Show(Connection.exception.Message, "Нет подключения.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            Effect.WaitForm(this, false);
        }

        protected override void OnClosed(EventArgs e)
        {
            SerializationDBInfo.SetInfo(dataBaseInfo);
            base.OnClosed(e);
        }
    }
}
