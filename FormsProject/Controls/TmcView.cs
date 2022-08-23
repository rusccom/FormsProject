using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Controls
{
    public partial class TmcView : UserControl
    {
        public TmcView()
        {
            InitializeComponent();
            CreateContextMenu();
            TmcList.CellMouseClick += TvResult_CellMouseClick;

            //TmcList.AfterCreateTableEvent += TmcList_AfterCreateTableEvent;
        }

        //private void TmcList_AfterCreateTableEvent()
        //{
        //    AddUsersColumnToTable();
        //}

        private void TvResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                switch (e.Button)
                {
                    case MouseButtons.Right:
                        TmcList.ClearSelection();
                        TmcList.Rows[e.RowIndex].Selected = true;
                        TmcList.ContextMenu.Show(this, this.PointToClient(Cursor.Position));
                        break;
                }
            }
        }

        private void CreateContextMenu()
        {
            ContextMenu contexMenu = new ContextMenu();
            MenuItem menuItemOpenForm = new MenuItem("Открыть");
            menuItemOpenForm.Click += MenuItemOpenForm_Click;

            MenuItem menuItemTmcMove = new MenuItem("Движение позиции");
            menuItemTmcMove.Click += MenuItemTmcMove_Click;

            contexMenu.MenuItems.Add(menuItemOpenForm);
            contexMenu.MenuItems.Add(menuItemTmcMove);

            TmcList.ContextMenu = contexMenu;
        }

        private void MenuItemOpenForm_Click(object sender, EventArgs e)
        {
            int tmcId = Convert.ToInt16(TmcList.SelectedRows[0].Cells["id"].Value);
            Forms.BaseForm form = Forms.FormManager.OpenForm(Operations.OperationCode.TMC, tmcId);

            if (form != null)
            {
                form.FormClosed -= Form_FormClosed;
                form.FormClosed += Form_FormClosed;
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshTable();
        }

        private void MenuItemTmcMove_Click(object sender, EventArgs e)
        {
            int tmcId = Convert.ToInt16(TmcList.SelectedRows[0].Cells["id"].Value);
            Forms.BaseForm form = Forms.FormManager.OpenForm(Operations.OperationCode.ReportTmcinfo, tmcId);

            if (form != null)
                form.Text = TmcList.SelectedRows[0].Cells["name"].Value.ToString();
        }

        public void FillData(Operations.OperationCode operationCode)
        {
            FillTmcViewTable();
            TmcGroup.AfterSelect -= TmcGroup_AfterSelect;
            TmcGroup.AfterSelect += TmcGroup_AfterSelect;
            if(TmcGroup.Nodes.Count == 0)
            FillTreeView();

            HideColumn(operationCode);

            TmcList.MultiSelect = true;
        }

        private void HideColumn(Operations.OperationCode operationCode)
        {
            TmcList.Columns["GroupId"].Visible = false;
            TmcList.Columns["LoginId"].Visible = false;
            TmcList.Columns["CreateDate"].Visible = false;

            if (AppInstance.UserId == 7)
            {
                TmcList.Columns["price"].Visible = false;
            }
        }

        private void TmcGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TmcList.Filter("GroupId = " + "'" + e.Node.Text + "'");
            //if (e.Node.Parent != null)
            //{
            //    TmcList.Filter("GroupId = " + "'" + e.Node.Text + "'");
            //} else
            //{
            //    TmcList.Filter(null);
            //}
        }

        private void FillTmcViewTable()
        {
            TmcList.AllowUserToAddRows = false;
            TmcList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RefreshTable();
        }

        //private void GetTmcViewPosition(ref int scrolPosition, ref int selectedIndex)
        //{
        //    if (TmcList.VerticalScrollingOffset != 0)
        //        scrolPosition = TmcList.FirstDisplayedScrollingRowIndex;
        //    if (TmcList.SelectedCells.Count > 0)
        //        selectedIndex = TmcList.SelectedCells[0].RowIndex;
        //}

        public void RefreshTable()
        {
            //int scrolPosition = 0;
            //int selectedIndex = 0;

            //GetTmcViewPosition(ref scrolPosition, ref selectedIndex);

            TmcList.CreateTtable(Operations.OperationCode.LIST_TMC, "order by [name] ASC");
            if(TmcGroup.SelectedNode != null)
            {
                TmcList.Filter("GroupId = " + "'" + TmcGroup.SelectedNode.Text + "'");

                //if(selectedIndex != 0)
                //{
                //    TmcList.FirstDisplayedScrollingRowIndex = scrolPosition;
                //    TmcList.Rows[selectedIndex].Selected = true;
                //}
            }
        }

        private void FillTreeView()
        {
            DataSet dataSet = SqlAdapter.SqlQueryAdapter.GetTable("TmcGroup" , "order by [name] ASC");
            DataTable table = dataSet.Tables[0];
            //table.DefaultView.Sort = "GroupId ASC";
            //table = table.DefaultView.ToTable();

            foreach (DataRow row in table.Rows)
            {
                string groupId = row["GroupId"].ToString();
                TreeNode[] nodeList = TmcGroup.Nodes.Find(groupId, true);
                if (nodeList.Length > 0)
                {
                    nodeList[0].Nodes.Add(row["id"].ToString(), row["name"].ToString());
                }
                else
                {
                    TmcGroup.Nodes.Add(row["id"].ToString(), row["name"].ToString());
                }
            }

            if(TmcGroup.Nodes.Count > 0)
            {
                TmcGroup.SelectedNode = TmcGroup.Nodes[0];
            }

            //TmcGroup.Nodes[1].Expand();
        }

        //private void AddUsersColumnToTable()
        //{
        //    DataColumn dataColumnPriceToRate = new DataColumn("columnPriceToRate");
        //    TmcList.GetDataTable.Columns.Add(dataColumnPriceToRate);

        //    TmcList.Columns["columnPriceToRate"].Width = 100;
        //    TmcList.Columns["columnPriceToRate"].ReadOnly = true;
        //    TmcList.Columns["columnPriceToRate"].HeaderText = "Цена по курсу";
        //    TmcList.Columns["columnPriceToRate"].Visible = false;

        //    DataColumn dataColumnPricePercent = new DataColumn("columnPricePercent");
        //    TmcList.GetDataTable.Columns.Add(dataColumnPricePercent);

        //    TmcList.Columns["columnPricePercent"].Width = 100;
        //    TmcList.Columns["columnPricePercent"].ReadOnly = true;
        //    TmcList.Columns["columnPricePercent"].HeaderText = "Цена -20%";
        //    TmcList.Columns["columnPricePercent"].Visible = false;
        //}

        //public void ShowUserColumns(bool isShown)
        //{
        //    TmcList.Columns["columnPriceToRate"].Visible = isShown;
        //    TmcList.Columns["columnPricePercent"].Visible = isShown;
        //}

        
    }
}
