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
    public partial class FormNonCashDebt : ReportView
    {
        public FormNonCashDebt()
        {
            InitializeComponent();
        }

        public override void SetFilter(string query = "")
        {
            query = " or Done = 0";
            base.SetFilter(query);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            tbResult.Columns["DocCode"].Visible = false;
        }

    }
}
