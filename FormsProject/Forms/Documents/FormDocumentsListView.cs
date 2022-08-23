using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsProject.Controls;

namespace FormsProject.Forms.Documents
{
    public partial class FormDocumentsListView : DocumentsView
    {
        DateTimePicker dtpFrom = new DateTimePicker();
        DateTimePicker dtpTo = new DateTimePicker();

        public FormDocumentsListView()
        {
            InitializeComponent();
        }

        private void CreateView()
        {
            UpdateResultTable();
            InitBaseFunction(tvResult);
            UpdateFilter();
        }

        private void UpdateView()
        {
            UpdateResultTable();
            UpdateFilter();
        }

        private void UpdateResultTable()
        {
            if (IsListDocument())
            {
                tvResult.CreateTtable(OperationCode, "order by [Done] ASC, [DocumentDate] DESC");
            }
            else
            {
                tvResult.CreateTtable(OperationCode, "order by [name] ASC");
            }
        }

        private void ToolStripItemInsert()
        {
            dtpFrom.Value = DateTime.Now.AddMonths(-3);
            ToolStripControlHost dtpFromHost = new ToolStripControlHost(dtpFrom);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, dtpFromHost);

            Label lbsep = new Label();
            lbsep.Text = " - ";
            ToolStripControlHost lbsepHost = new ToolStripControlHost(lbsep);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, lbsepHost);


            ToolStripControlHost dtpToHost = new ToolStripControlHost(dtpTo);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, dtpToHost);

            dtpFrom.ValueChanged += DtpFrom_ValueChanged;
            dtpTo.ValueChanged += DtpFrom_ValueChanged;
        }

        private void UpdateFilter()
        {
            if (IsListDocument())
            {
                SetFilter();
            }
        }

        //private string GetUserDocDate()
        //{
        //    var dateTo = dtpTo.Value.AddDays(1);
        //    return "DocumentDate >= '" + dtpFrom.Value.Date + "' and DocumentDate <= '" + dateTo.Date + "'";
        //}

        private void DtpFrom_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        public override void OpenFilledForm(TableView table = null)
        {
            base.OpenFilledForm(tvResult);
        }

        public override void SetFilter()
        {
            //if (IsListDocument())
            //{
            //    if (query != string.Empty)
            //    {
            //        query += " and " + GetUserDocDate();
            //    }
            //    else
            //    {
            //        query = GetUserDocDate();
            //    }
            //}
            //query += GetUserDocDate();
            //Service.UserFilter.SetFilter(tvResult, query, OperationCode);
            userFilter.DateTimeFrom = dtpFrom.Value.Date;
            userFilter.DateTimeTo = dtpTo.Value.Date;
            base.SetFilter();
        }

        public override void RefreshTable()
        {
            UpdateView();
            base.RefreshTable();
        }

        protected override void OnShown(EventArgs e)
        {
            if (IsListDocument())
                ToolStripItemInsert();
            CreateView();
            base.OnShown(e);
        }
    }
}
