using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms.Documents.ImportTable
{
    public partial class FormImportTable : Form
    {
        public FormImportTable(DataTable dataTable, Dictionary<string, string> tableColumns)
        {
            InitializeComponent();
            dgvResult.AllowUserToAddRows = false;

            dcbTmcGroup.FillComboBox(true);

            PopulateGridView(dataTable, tableColumns);
        }

        private void AddColumnToGrid(DataTable dataTable)
        {
            foreach (DataColumn columnTable in dataTable.Columns)
            {
                dgvResult.Columns.Add(columnTable.ColumnName, columnTable.ColumnName);
            }
        }

        private void AddComboCellToFirstRow(Dictionary<string, string> tableColumns)
        {
            int indexNewRow = dgvResult.Rows.Add();
            DataGridViewRow row = dgvResult.Rows[indexNewRow];
            
            for (int i = 0; i < dgvResult.Columns.Count; i++)
            {
                DataGridViewComboBoxCell cellComboBox = new DataGridViewComboBoxCell();
                cellComboBox.DataSource = tableColumns.Keys.ToList();
                row.Cells[i] = cellComboBox;
            }
        }

        private void AddDataToGridView(DataTable dataTable)
        {
            int indexNewRow = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                indexNewRow = dgvResult.Rows.Add();
                DataGridViewRow dgvRow = dgvResult.Rows[indexNewRow];
                foreach (DataColumn column in row.Table.Columns)
                {
                    dgvRow.Cells[column.ColumnName].Value = row[column.ColumnName];
                }
            }
        }

        private void PopulateGridView(DataTable dataTable, Dictionary<string, string> tableColumns)
        {
            AddColumnToGrid(dataTable);

            AddComboCellToFirstRow(tableColumns);

            AddDataToGridView(dataTable);
        }

        private void bOk_Click(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
