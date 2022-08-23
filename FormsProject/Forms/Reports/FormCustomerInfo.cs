using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms.Reports
{
    public partial class FormCustomerInfo : ReportView
    {
        public FormCustomerInfo()
        {
            InitializeComponent();
            AddTextBoxCustomer();
        }

        public override void OnFormInit()
        {
            base.OnFormInit();

            string result = File.ReadAllText(Application.StartupPath + "/SqlQuery/Reports/CustomerDebt.txt", Encoding.Default);
            result = result.Replace("#CusId#", ReportValue.ToString());

            DataTable dataTable = DataProject.Scripts.SelectQuery.GetSelect(result, AppInstance.sqlConnection).Tables[0];
            lallBalance.Text = dataTable.Rows[0]["Debts"].ToString();
            lNonCashIn.Text = dataTable.Rows[0]["NonCashInDebt"].ToString();
            lNonCashOut.Text = dataTable.Rows[0]["NonCashOutDebt"].ToString();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        public override void RefreshForm()
        {
            base.RefreshForm();
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal prodIn = 0;
            decimal prodOut = 0;
            decimal moneyIn = 0;
            decimal moneyOut = 0;

            foreach (DataGridViewRow row in tbResult.Rows)
            {
                switch ((int)row.Cells["DocCode"].Value)
                {
                    case 1:
                        prodIn += (decimal)row.Cells["suma"].Value;
                        break;
                    case 2:
                        prodOut += (decimal)row.Cells["suma"].Value;
                        break;
                    case 3:
                        moneyIn += (decimal)row.Cells["suma"].Value;
                        break;
                    case 4:
                        moneyOut += (decimal)row.Cells["suma"].Value;
                        break;
                }
            }

            lpIn.Text = prodIn.ToString();
            lpOut.Text = prodOut.ToString();
            lmIn.Text = moneyIn.ToString();
            lmOut.Text = moneyOut.ToString();
        }

        private void AddTextBoxCustomer()
        {
            ComboBox cb = new ComboBox();
            cb.Items.Add("Все документы");
            cb.Items.Add("Приход товара");
            cb.Items.Add("Расход товара");
            cb.Items.Add("Приход денег");
            cb.Items.Add("Расход денег");
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.SelectedIndex = 0;

            cb.SelectedIndexChanged += Cb_SelectedIndexChanged;

            ToolStripControlHost cbHost = new ToolStripControlHost(cb);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, cbHost);

            //Label lbsep = new Label();
            //lbsep.Text = " - ";
            //ToolStripControlHost lbsepHost = new ToolStripControlHost(lbsep);
            //UserToolStrip.Items.Insert(UserToolStrip.Items.Count, lbsepHost);
        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = ((ComboBox)(sender)).SelectedIndex;
            if (selectIndex == 0)
            {
                SetFilter();
            }
            else
            {
                SetFilter(" and DocCode = " + selectIndex);
            }
        }
    }
}
