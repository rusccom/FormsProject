using FormsProject.Controls;
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
    public partial class FormTMCInfo : ReportView
    {
        DataComboBox dcbCustomer = new DataComboBox();

        public FormTMCInfo()
        {
            InitializeComponent();
            dcbCustomer.FieldName = "[name]";
            dcbCustomer.TableName = "[Customer]";
            dcbCustomer.Width = 300;
            dcbCustomer.FillComboBox(true);
        }

        private void ToolStripItemInsert()
        {
            Label lbsep = new Label();
            lbsep.Text = " - ";
            ToolStripControlHost lbsepHost = new ToolStripControlHost(lbsep);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, lbsepHost);

            ToolStripControlHost dtpToHost = new ToolStripControlHost(dcbCustomer);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, dtpToHost);

            AddDefaultIdToComboBox();

            dcbCustomer.SelectedValueChanged += DcbCustomer_SelectedValueChanged;
        }

        private void DcbCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            SetFilter();
        }

        private void AddDefaultIdToComboBox()
        {
            DataTable table = (DataTable)dcbCustomer.DataSource;
            DataRow row = table.NewRow();
            row["id"] = 0;
            row["name"] = "Все контрагенты";
            row["PriceTypeId"] = 1;
            row["address"] = 1;
            row["info"] = 1;
            row["LoginId"] = 1;
            row["CreateDate"] = DateTime.Now;
            table.Rows.InsertAt(row, 0);
            dcbCustomer.SelectedIndex = 0;
        }

        private void AddTotalToGrid()
        {
            Dictionary<string, decimal> total = CalculateQuantitySum();
            if (total.Count > 0)
            {
                lAllQuantity.Text = total["AllQuantity"].ToString();
                lAllSum.Text = total["AllSum"].ToString();
                lInQuantity.Text = total["InQuantity"].ToString();
                lInSum.Text = total["InSum"].ToString();
                lOutQuantity.Text = total["OutQuantity"].ToString();
                lOutSum.Text = total["OutSum"].ToString();
            }
        }

        private Dictionary<string, decimal> CalculateQuantitySum()
        {
            Dictionary<string, decimal> total = new Dictionary<string, decimal>();
            total["InSum"] = 0;
            total["InQuantity"] = 0;
            total["OutSum"] = 0;
            total["OutQuantity"] = 0;
            total["AllSum"] = 0;
            total["AllQuantity"] = 0;

            foreach (DataGridViewRow row in tbResult.Rows)
            {
                switch((int)row.Cells["DocCode"].Value)
                {
                    case 1:
                        total["InSum"] += Convert.ToDecimal(row.Cells["price"].Value) * Convert.ToDecimal(row.Cells["quantity"].Value);
                        total["InQuantity"] += Convert.ToDecimal(row.Cells["quantity"].Value);
                        break;
                    case 2:
                        total["OutSum"] += Convert.ToDecimal(row.Cells["price"].Value) * Convert.ToDecimal(row.Cells["quantity"].Value);
                        total["OutQuantity"] += Convert.ToDecimal(row.Cells["quantity"].Value);
                        break;
                }

                total["AllSum"] += Convert.ToDecimal(row.Cells["price"].Value) * Convert.ToDecimal(row.Cells["quantity"].Value);
                total["AllQuantity"] += Convert.ToDecimal(row.Cells["quantity"].Value);
            }

            return total;
        }

        public override void SetFilter(string query = "")
        {
            if(dcbCustomer.Items.Count != 0 && dcbCustomer.SelectedIndex != 0)
            {
                query += " and CustomerId = '" + dcbCustomer.Text + "'";
            }
            base.SetFilter(query);
        }

        public override void RefreshForm()
        {
            AddTotalToGrid();
            base.RefreshForm();
        }

        public override void RefreshTable()
        {
            base.RefreshTable();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ToolStripItemInsert();
        }
    }
}
