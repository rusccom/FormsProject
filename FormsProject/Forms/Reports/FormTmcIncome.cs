using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms.Reports
{
    public partial class FormTmcIncome : ReportView
    {
        public FormTmcIncome()
        {
            InitializeComponent();
            SetOneMountDateIncome();
            InitReportTable();
            tbResult.MultiSelect = true;
        }

        private void InitReportTable()
        {
            this.Cursor = Cursors.WaitCursor;
            tbResult.CreateTtableFromSelect(ReportQuery.GetQuery(GetDateTimeValue(), Operations.OperationCode.ReportTmcIncome));
            UpdateTotal();
            this.Cursor = Cursors.Default;
        }

        private List<DateTime> GetDateTimeValue()
        {
            List <DateTime> datetimeList = new List<DateTime>();
            datetimeList.Add(dtpFrom.Value.Date);
            datetimeList.Add(dtpTo.Value.Date);

            return datetimeList;
        }

        private void SetOneMountDateIncome()
        {
            dtpTo.Value = DateTime.Now;
            dtpFrom.Value = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, 1);
        }

        public override void SetFilter(string query = "")
        {
            //base.SetFilter(query);
        }

        public override void RefreshTable()
        {
            InitReportTable();
            //base.RefreshTable();
        }

        private void UpdateTotal()
        {
            decimal inSum = 0;
            decimal outSum = 0;
            decimal outQuantity = 0;
            decimal income = 0;
            //decimal marz = 0;
            //decimal marzSum = 0;

            foreach(DataGridViewRow row in tbResult.Rows)
            {
                inSum += (decimal) row.Cells["InSum"].Value;
                outSum += (decimal)row.Cells["suma"].Value;
                decimal quantity = (decimal)row.Cells["quantity"].Value;
                outQuantity += quantity;
                
                //marz = (decimal)row.Cells["AddPricePercent"].Value;
                income += (decimal)row.Cells["Income"].Value;
                //marzSum += marz * quantity;
            }
            if (tbResult.Rows.Count > 0)
            {
                lIncome.Text = income.ToString();
                lInSum.Text = inSum.ToString();
                lOutSum.Text = outSum.ToString();
                lOutQuantity.Text = outQuantity.ToString();

                decimal marza = ((outSum / inSum)-1)*100;
                lMarz.Text = decimal.Round(marza, 2).ToString();
            }
        }
    }
}
