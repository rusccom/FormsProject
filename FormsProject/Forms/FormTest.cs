using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms
{
    public partial class FormTest : BaseForm
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int qwe = (int)Operations.OperationCode.LIST_CUSTOMER;
            SqlCommand command = new SqlCommand(textBox1.Text, AppInstance.sqlConnection);
            command.ExecuteReader();
        }
    }
}
