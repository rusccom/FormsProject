using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsProject.Forms;

namespace FormsProject.Authentication
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            dcbLogin.FillComboBox();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (CheckUser())
            {
                AppInstance.UserId = (int) dcbLogin.SelectedValue;
                AppInstance.UserName = dcbLogin.SelectedText;

                DialogResult = DialogResult.OK;
                this.Close();
            } 
        }

        private bool CheckUser()
        {
            bool result = false;

            string tableName = Operations.Operation.GetTableNameByOperationCode(Operations.OperationCode.SYSTEM_LOGIN);

            string where = SqlAdapter.SqlQueryAdapter.WhereConstructor("[id]", "=", dcbLogin.SelectedValue.ToString());
            DataTable table = SqlAdapter.SqlQueryAdapter.GetTable(tableName, where).Tables[0];

            string dataPass = table.Rows[0]["pass"].ToString();
            string userPass = tbPass.Text;

            bool isExist = DataProject.TempTable.TempTableHandler.IsTableExist((int)dcbLogin.SelectedValue, AppInstance.sqlConnection);
            if (!isExist)
            {
                if (string.Compare(dataPass, userPass) == 0)
                {
                    result = true;
                    DataProject.TempTable.TempTableHandler.CreateTempTable((int)dcbLogin.SelectedValue, AppInstance.sqlConnection);
                } else
                {
                    MessageBox.Show("Не правельный пароль.", "Ошибка авторизации.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Пользователь уже в системе.", "Вход в систему.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
