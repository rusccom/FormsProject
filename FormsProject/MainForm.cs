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
using FormsProject.Forms.Directory;
using FormsProject.Operations;
using FormsProject.Forms.Reports;

namespace FormsProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserToolStripMenu.Visible = false;

            ///Online store under dev. 
            storeToolStripMenuItem.Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.MdiChildren.Count<Form>() > 0)
            {
                if (MessageBox.Show("Выйти из программы?", "Выключение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiTMC_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.LIST_TMC);
        }

        private void tsmiGroupTmc_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.TMC_GROUP_LIST);
        }

        private void tsmiClient_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.LIST_CUSTOMER);
        }

        private void tsmiDocumentIn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.LIST_PRODUCT_IN);
        }

        private void tsmiDocumentOut_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.LIST_PRODUCT_OUT);
        }

        private void tsmiDocumentMoneyIn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.LIST_MONEY_IN);
        }

        private void tsmiDocumentMoneyOut_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.LIST_MONEY_OUT);
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            //FormManager.OpenForm(OperationCode.SYSTEM_LOGIN);
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            FormTest ft = new FormTest();
            ft.Show();
        }

        private void единицаИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.LIST_UNIT);
        }

        private void отчет1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.ReportTmcIncome);
        }

        private void остаткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.ReportQuantity);
        }

        private void списокЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(OperationCode.ListOrdersIS);
        }
    }
}
