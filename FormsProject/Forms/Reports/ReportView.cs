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
    public partial class ReportView : BaseForm
    {
        public DateTimePicker dtpFrom = new DateTimePicker();
        public DateTimePicker dtpTo = new DateTimePicker();

        protected object ReportValue = null;

        public ReportView()
        {
            InitializeComponent();
            ToolStripItemInsert();
        }

        public void InitReport(object value)
        {
            ReportValue = value;
            InitTable(ReportValue);
            OnFormInit();
        }

        private void InitTable(object value)
        {
            tbResult.CreateTtableFromSelect(ReportQuery.GetQuery(value, OperationCode));
        }

        public virtual void OnFormInit()
        {
            ResultTableSetting();
            SetFilter();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        public virtual void RefreshForm()
        {

        }

        public virtual void RefreshTable()
        {
            InitReport(ReportValue);
        }

        public virtual void SetFilter(string query = "")
        {
            var dateTo = dtpTo.Value.AddDays(1);
            string where = string.Empty;

            if (query == string.Empty)
            {
                where = "DocumentDate >= '" + dtpFrom.Value.Date + "' and DocumentDate <= '" + dateTo.Date + "'";
            }
            else
            {
                where = "(DocumentDate >= '" + dtpFrom.Value.Date + "' and DocumentDate <= '" + dateTo.Date + "')" + query;
            }

            tbResult.Filter(where);
            RefreshForm();
        }

        protected void ResultTableSetting()
        {
            tbResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbResult.CellDoubleClick -= TbResult_CellDoubleClick;
            tbResult.CellDoubleClick += TbResult_CellDoubleClick;
        }

        public virtual void TbResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbResult.SelectedRows.Count > 0)
            {
                int id = (int) tbResult.SelectedRows[0].Cells["id"].Value;
                int docCode = (int)tbResult.SelectedRows[0].Cells["DocCode"].Value;
                Operations.OperationCode docOperationCode = Operations.Operation.GetOperationCodeByDocCode(docCode);

                BaseForm form = FormManager.OpenForm(docOperationCode, id);
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

        private void ToolStripItemInsert()
        {
            dtpFrom.Value = DateTime.Now.AddMonths(-6);
            ToolStripControlHost dtpFromHost = new ToolStripControlHost(dtpFrom);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, dtpFromHost);

            Label lbsep = new Label();
            lbsep.Text = " - ";
            ToolStripControlHost lbsepHost = new ToolStripControlHost(lbsep);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, lbsepHost);
            
            ToolStripControlHost dtpToHost = new ToolStripControlHost(dtpTo);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, dtpToHost);

            //SetFilter();

            dtpFrom.ValueChanged += DtpFrom_ValueChanged;
            dtpTo.ValueChanged += DtpFrom_ValueChanged;
        }

        private void DtpFrom_ValueChanged(object sender, EventArgs e)
        {
            SetFilter();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
