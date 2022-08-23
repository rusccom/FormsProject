using FormsProject.Controls;
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
    public partial class FormReportQuantity : ReportView
    {
        DataComboBox dcbTmcGroup = new DataComboBox();
        public FormReportQuantity()
        {
            InitializeComponent();
            SetDateTimeProperty();
            InitReportTable();

            dcbTmcGroup.FieldName = "[name]";
            dcbTmcGroup.TableName = "[TmcGroup]";
            dcbTmcGroup.Width = 300;
            dcbTmcGroup.FillComboBox(true);

            ResultTableSetting();
            CreateContextMenu();
            tbResult.CellMouseClick += TvResult_CellMouseClick;
        }

        private void CalculateTotalRow()
        {
            lCount.Text = tbResult.Rows.Count.ToString();
        }

        private void ToolStripItemInsert()
        {
            Label lbsep = new Label();
            lbsep.Text = " - ";
            ToolStripControlHost lbsepHost = new ToolStripControlHost(lbsep);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, lbsepHost);

            ToolStripControlHost dtpToHost = new ToolStripControlHost(dcbTmcGroup);
            UserToolStrip.Items.Insert(UserToolStrip.Items.Count, dtpToHost);

            AddDefaultIdToComboBox();

            dcbTmcGroup.SelectedValueChanged += DcbCustomer_SelectedValueChanged;
        }

        private void DcbCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            SetFilterByComboBox();
            CalculateTotalRow();
        }

        private void AddDefaultIdToComboBox()
        {
            DataTable table = (DataTable)dcbTmcGroup.DataSource;
            DataRow row = table.NewRow();
            row["id"] = 0;
            row["name"] = "Все группы";
            row["GroupId"] = 1;
            row["LoginId"] = 1;
            row["CreateDate"] = DateTime.Now;
            table.Rows.InsertAt(row, 0);
            dcbTmcGroup.SelectedIndex = 0;
        }

        private void SetDateTimeProperty()
        {
            dtpFrom.Value = dtpTo.Value.AddDays(-3).Date;
        }
        private void InitReportTable()
        {
            this.Cursor = Cursors.WaitCursor;
            tbResult.CreateTtableFromSelect(ReportQuery.GetQuery(GetDateTimeValue(), Operations.OperationCode.ReportQuantity));
            this.Cursor = Cursors.Default;
        }

        private List<DateTime> GetDateTimeValue()
        {
            List<DateTime> datetimeList = new List<DateTime>();
            datetimeList.Add(dtpFrom.Value.Date);
            datetimeList.Add(dtpTo.Value.Date);

            return datetimeList;
        }

        private void TvResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                switch (e.Button)
                {
                    case MouseButtons.Right:
                        tbResult.ClearSelection();
                        tbResult.Rows[e.RowIndex].Selected = true;
                        tbResult.ContextMenu.Show(this, this.PointToClient(Cursor.Position));
                        break;
                }
            }
        }
        private void CreateContextMenu()
        {
            ContextMenu contexMenu = new ContextMenu();

            MenuItem menuItemTmcMove = new MenuItem("Движение позиции");
            menuItemTmcMove.Click += MenuItemTmcMove_Click;

            contexMenu.MenuItems.Add(menuItemTmcMove);

            tbResult.ContextMenu = contexMenu;
        }

        private void MenuItemTmcMove_Click(object sender, EventArgs e)
        {
            int tmcId = Convert.ToInt16(tbResult.SelectedRows[0].Cells["TmcId"].Value);
            Forms.BaseForm form = Forms.FormManager.OpenForm(Operations.OperationCode.ReportTmcinfo, tmcId);

            if (form != null)
                form.Text = tbResult.SelectedRows[0].Cells["TmcName"].Value.ToString();
        }

        private void SetFilterByComboBox()
        {
            string query = string.Empty;

            if (dcbTmcGroup.Items.Count != 0)
            {
                switch (dcbTmcGroup.SelectedIndex)
                {
                    case 0:
                        break;
                    default:
                        query += "GroupId like '%" + dcbTmcGroup.Text + "%'";
                        break;
                }

                tbResult.Filter(query);
            }
        }

        public override void SetFilter(string query = "")
        {
            InitReportTable();
            SetFilterByComboBox();
            CalculateTotalRow();
        }

        public override void RefreshTable()
        {
            InitReportTable();
            SetFilterByComboBox();
            CalculateTotalRow();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ToolStripItemInsert();
        }

        public override void TbResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbResult.SelectedRows.Count > 0)
            {
                int id = (int)tbResult.SelectedRows[0].Cells["Tmcid"].Value;

                BaseForm form = FormManager.OpenForm(Operations.OperationCode.TMC, id);
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
    }
}
