using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataProject.Scripts;

namespace FormsProject.Controls
{
    public partial class TableView : DataGridView
    {
        public delegate void AfterCreateTable();
        public event AfterCreateTable AfterCreateTableEvent;

        int scrolPosition = 0;
        int selectedIndex = 0;

        private DataTable dataTable;

        private Operations.OperationCode _operationCode;

        public DataTable GetDataTable
        {
            get { return dataTable; }
        }

        public TableView()
        {
            InitializeComponent();
            this.BackgroundColor = SystemColors.ControlLightLight;
            this.MultiSelect = false;
            this.ReadOnly = true;
        }

        public void CreateTtable(Operations.OperationCode operationCode, string where = null)
        {
            _operationCode = operationCode;

            GetTmcViewPosition(ref scrolPosition, ref selectedIndex);

            string tableName = Operations.Operation.GetTableNameByOperationCode(_operationCode);
            if (where == null)
            {
                dataTable = SelectQuery.GetTableByTableName(tableName, AppInstance.sqlConnection).Tables[0];
            }
            else
            {
                dataTable = SelectQuery.GetTableByTableNameWhere(tableName, where, AppInstance.sqlConnection).Tables[0];
            }

            this.DataSource = dataTable;

            dataTable.TableName = tableName;
            ChangeColumnType();
            Forms.TableSetting.SetColumnName(this);
            //this.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells, true);
            AfterCreateTableEvent?.Invoke();
        }

        public void CreateTtableFromSelect(string selectQuery)
        {
            GetTmcViewPosition(ref scrolPosition, ref selectedIndex);

            dataTable = SelectQuery.GetSelect(selectQuery, AppInstance.sqlConnection).Tables[0];

            this.DataSource = dataTable;

            dataTable.TableName = "Report";

            ChangeColumnType();
            Forms.TableSetting.SetColumnName(this);
            //this.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells, true);
            AfterCreateTableEvent?.Invoke();
        }

        private void GetTmcViewPosition(ref int scrolPosition, ref int selectedIndex)
        {
            //if (this.VerticalScrollingOffset != 0)
                scrolPosition = this.FirstDisplayedScrollingRowIndex;
            if (this.SelectedCells.Count > 0)
                selectedIndex = this.SelectedCells[0].RowIndex;
        }

        public void Filter(string where)
        {
            dataTable.DefaultView.RowFilter = where;

            if (selectedIndex != 0 && this.Rows.Count > selectedIndex)
            {
                this.FirstDisplayedScrollingRowIndex = scrolPosition;
                this.Rows[selectedIndex].Selected = true;
            }
        }

        private void ChangeColumnType()
        {
            for (int i = 0; i < Columns.Count; i++)
            {
                switch (Columns[i].Name)
                {
                    case "Done":
                        ChangeTypeOfColumn(Columns[i]);
                        break;

                    case "NonCash":
                        ChangeTypeOfColumn(Columns[i]);
                        break;

                    case "DocCode":
                        Columns[i].Visible = false;
                        break;
                }
            }
        }

        private void ChangeTypeOfColumn(DataGridViewColumn column)
        {
            if (column.GetType() != typeof(DataGridViewCheckBoxColumn))
            {
                DataGridViewCheckBoxColumn cbColumn = new DataGridViewCheckBoxColumn();
                cbColumn.Name = column.Name;
                cbColumn.DataPropertyName = column.Name;
                this.Columns.Remove(column);
                this.Columns.Insert(column.Index, cbColumn);
            }
        }

        protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
        {
            DataGridViewColumn column = e.Column;

            switch (column.Name)
            {
                case "id":
                    IdColumnHandling(column);
                    break;
            }
            base.OnColumnAdded(e);
        }

        protected void IdColumnHandling(DataGridViewColumn column)
        {
            switch(_operationCode)
            {
                case Operations.OperationCode.LIST_TMC:
                    column.Visible = true;
                    column.HeaderText = "Артикул";
                    column.Width = 60;
                    break;

                default:
                    column.Visible = false;
                    break;
            }
        }

    protected override void OnDataError(bool displayErrorDialogIfNoHandler, DataGridViewDataErrorEventArgs e)
        {
            displayErrorDialogIfNoHandler = false;
            base.OnDataError(displayErrorDialogIfNoHandler, e);
        }
    }
}
