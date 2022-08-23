using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsProject.Operations;
using System.Data.SqlClient;
using FormsProject.BaseSelection;
using FormsProject.Authentication;
using FormsProject.Forms;

namespace FormsProject
{
    static public class AppInstance
    {
        static private string userName;
        static private int userId;

        static private SqlConnection _sqlConnection;

        static public MainForm mainForm;

        static private Dictionary<OperationCode, OperationSetting> operationSettingCollection = new Dictionary<OperationCode, OperationSetting>();

        static private Dictionary<OperationCode, BaseForm> formsCollection = new Dictionary<OperationCode, BaseForm>();

        static public SqlConnection sqlConnection
        {
            get {
                int i = 0;
                while(_sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    _sqlConnection = DataProject.SqlDataBase.Connection.Open(_sqlConnection.ConnectionString);

                    if(_sqlConnection.State == System.Data.ConnectionState.Open)
                    {
                        bool isUserExist = DataProject.TempTable.TempTableHandler.IsTableExist(UserId, _sqlConnection);
                        if (!isUserExist)
                        {
                            DataProject.TempTable.TempTableHandler.CreateTempTable(UserId, _sqlConnection);
                        }
                        else
                        {
                            MessageBox.Show("У вас была потеряноа связь с сервером, при повторной попытке подключения оказалось что пользователь с таким именем уже в системе.", "Повторное подключение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            _sqlConnection.Close();
                        }

                        break;
                    }

                    if(i >= 10)
                    {
                        MessageBox.Show("Почему-то не удалось подключиться к базе.", "Опа, у вас проблемы с подключением.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    i++;
                }

                return _sqlConnection;
            }
            set { _sqlConnection = value; }
        }

        static public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        static public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        static public Dictionary<OperationCode, BaseForm> FormsCollection
        {
            get { return formsCollection; }
        }

        static public Dictionary<OperationCode, OperationSetting> OperationSettingCollection
        {
            get { return operationSettingCollection; }
            set { operationSettingCollection = value; }
        }

        static public void Run()
        {
            if(GetConnection() && Authentication())
            {
                RunApplication();
            }
        }

        static private bool GetConnection()
        {
            bool result = false;

            FormBaseSelection formSelection = new FormBaseSelection();
            switch (formSelection.ShowDialog())
            {
                case DialogResult.OK:
                    sqlConnection = formSelection.connection;
                    result = true;
                    break;
            }

            return result;
        }

        static private void RunApplication()
        {
            mainForm = new MainForm();
        }

        static private bool Authentication()
        {
            bool result = false;
            FormAuthorization form = new FormAuthorization();
            switch (form.ShowDialog())
            {
                case DialogResult.OK:
                    result = true;
                    break;
            }
            

            return result;
        }
    }
}
