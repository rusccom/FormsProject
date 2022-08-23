using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.BaseSelection
{
    public partial class FormAddNewDataBase : Form
    {
        public FormAddNewDataBase()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (tbPass.Text != string.Empty & tbBase.Text != string.Empty & tbName.Text != string.Empty & tbServer.Text != string.Empty)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            } else
            {
                if(MessageBox.Show("Заполните все данные.", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
                
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
