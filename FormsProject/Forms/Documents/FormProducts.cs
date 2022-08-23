using FormsProject.Controls;
using FormsProject.Forms.Service;
using FormsProject.TableDataHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms.Documents
{
    public partial class FormProducts : FormDirectoryBase
    {
        public FormProducts()
        {
            InitializeComponent();
            dcbCustomer.FillComboBox();
            dcbPriceSelect.FillComboBox(true);

            tmcView.TmcList.CellMouseDoubleClick += TmcList_CellMouseDoubleClick;
            tableResult.CellMouseClick += TableResult_CellMouseClick;
            tableResult.CellEndEdit += TableResult_CellEndEdit;
            tbUserItemsFilter.KeyUp += TbUserItemsFilter_KeyUp;
            tbTmcView.KeyUp += TbTmcView_KeyUp;

            tableResult.AfterCreateTableEvent += TableResult_AfterCreateTableEvent;

            CreateContextMenu();
        }

        private void TableResult_AfterCreateTableEvent()
        {
            RateAndPercentColumns.AddRateAndPercentColumnToTable(tableResult);
            cbAddRate.CheckedChanged += CbAddRate_CheckedChanged;
            dtbRate.KeyUp += DtbRate_KeyUp;
        }

        private void DtbRate_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    string strValue = ((DataTextBox)sender).Text;
                    decimal value = 0;
                    if (decimal.TryParse(strValue, out value))
                    {
                        RateAndPercentColumns.CalculateRateAndPercentColumns(tableResult, value, OperationCode);
                    }
                    break;
            }
        }

        private void CbAddRate_CheckedChanged(object sender, EventArgs e)
        {
            dtbRate.Visible = cbAddRate.Checked;
            RateAndPercentColumns.ShowRateAndPercentColumn(tableResult, cbAddRate.Checked);
        }

        private void TbTmcView_KeyUp(object sender, KeyEventArgs e)
        {
            userFilter.TextBoxValue = tbTmcView.Text;
            userFilter.SetFilter(tmcView.TmcList, Operations.OperationCode.LIST_TMC);
        }

        private void TbUserItemsFilter_KeyUp(object sender, KeyEventArgs e)
        {
            userFilter.TextBoxValue = tbUserItemsFilter.Text;
            userFilter.SetFilter(tableResult, OperationCode);
        }

        private void DcbCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            dcbPriceSelect.SelectedValue = ((DataRowView)((DataComboBox)sender).SelectedItem)["PriceTypeId"];
        }

        private void PopulatePriceComboBox()
        {
            switch (OperationCode)
            {
                case Operations.OperationCode.PRODUCT_OUT:
                    dcbPriceSelect.SelectedValue = ((DataRowView)dcbCustomer.SelectedItem)["PriceTypeId"];
                    dcbCustomer.SelectedValueChanged += DcbCustomer_SelectedValueChanged;
                    break;
                case Operations.OperationCode.PRODUCT_IN:
                    dcbPriceSelect.SelectedValue = 1;
                    dcbPriceSelect.Enabled = false;
                    break;
            }
        }

        public override void LoadForm(int recordId = 0)
        {
            tmcView.FillData(OperationCode);
            base.LoadForm(recordId);
            TableSetting.SetDocumentProductItemProperty(tableResult);
            PopulatePriceComboBox();
            AddNumericPositionToTable();
            CalculateDocument();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            CalculateDocument();
        }

        private void AddNumericPositionToTable()
        {

            //DataTable dataTable = tableResult.GetDataTable;

            //DataColumn dataColumn = new DataColumn("PosNum");
            //dataTable.Columns.Add(dataColumn);
            //tableResult.Columns["PosNum"].ReadOnly = true;
            //tableResult.Columns["PosNum"].HeaderText = "№";
            //tableResult.Columns["PosNum"].DisplayIndex = 0;
            //tableResult.Columns["PosNum"].Width = 35;
            DataGridViewColumn dataGridViewColumn = tableResult.Columns["PosNum"];
            if (dataGridViewColumn == null)
            {
                tableResult.Columns.Add("PosNum", "№");
                tableResult.Columns["PosNum"].ReadOnly = true;
                tableResult.Columns["PosNum"].DisplayIndex = 0;
                tableResult.Columns["PosNum"].Width = 35;
            }
        }

        private void CreateContextMenu()
        {
            ContextMenu contexMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem("Удалить строку?");
            menuItem.Click += MenuItem_Click;
            contexMenu.MenuItems.Add(menuItem);

            tableResult.ContextMenu = contexMenu;
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить строку?", "Удаление строки", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                int rowIndex = tableResult.SelectedRows[0].Index;
                DeleteRow(rowIndex);
            }
        }

        private void TableResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    tableResult.ClearSelection();
                    tableResult.Rows[e.RowIndex].Selected = true;
                    tableResult.ContextMenu.Show(tableResult, tableResult.PointToClient(Cursor.Position));
                    break;
            }
        }

        private void DeleteRow(int rowIndex)
        {
            tableResult.Rows.RemoveAt(rowIndex);
            CalculateDocument();
        }

        private void TableResult_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculatItemSum(e.RowIndex);
        }

        private void CalculatItemSum(int rowIndex)
        {
            decimal count = Convert.ToDecimal(tableResult["quantity", rowIndex].Value);
            decimal price = Convert.ToDecimal(tableResult["price", rowIndex].Value);

            tableResult["suma", rowIndex].Value = count * price;

            CalculateDocument();
        }

        private void CalculateDocument()
        {
            decimal documentSum = 0;
            int itemCount = 0;

            foreach (DataGridViewRow row in tableResult.Rows)
            {
                decimal sum = Convert.ToDecimal(row.Cells["suma"].Value);
                documentSum += sum;
                itemCount++;
                tableResult["PosNum", itemCount-1].Value = itemCount.ToString();
            }

            lCountRow.Text = itemCount.ToString();
            lDocumentSuma.Text = documentSum.ToString();
        }

        private void TmcList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int tmcId = (int) tmcView.TmcList.SelectedRows[0].Cells["id"].Value;
            InsertRow(tmcId);
        }

        private void InsertRow(int tmcId)
        {
            FormCount formCount = new FormCount();

            if (formCount.ShowDialog() == DialogResult.OK)
            {
                AddNewRow(tmcId, formCount.Count);
                tableResult.FirstDisplayedScrollingRowIndex = tableResult.Rows.Count - 1;
                CalculateDocument();
            }
        }

        private bool CheckQuantityTmc(DataRow[] dataRow, decimal quantity)
        {
            bool result = true;
            if (OperationCode != Operations.OperationCode.PRODUCT_IN)
            {
                decimal tmcQuantity = (decimal)dataRow[0]["quantity"];

                if (tmcQuantity < quantity)
                {
                    DialogResult dialogResult = MessageBox.Show("На складе не хватает количества, продаем в минус?", "Не хватает количества.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    switch (dialogResult)
                    {
                        case DialogResult.No:
                            result = false;
                            break;
                    }
                }
            }

            return result;
        }

        private void AddNewRow(int tmcId, decimal quantity)
        {
            DataRow[] dataRow = tmcView.TmcList.GetDataTable.Select("id = " + tmcId.ToString());

            if (dataRow.Length > 1)
            {
                MessageBox.Show("Критичиская ошибка, повторяется 'id' ТМЦ.", "Критичиская ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (CheckQuantityTmc(dataRow, quantity))
            {

                DataRow row = tableResult.GetDataTable.NewRow();

                row["TmcId"] = tmcId;
                row["TmcName"] = dataRow[0]["name"].ToString();
                row["UnitId"] = dataRow[0]["UnitId"].ToString();

                string priceColumn = GetPriceColumn();

                decimal price = (decimal)dataRow[0][priceColumn];
                row["price"] = price;
                row["quantity"] = quantity;
                row["suma"] = quantity * price;

                tableResult.GetDataTable.Rows.Add(row);
            }
        }

        private string GetPriceColumn()
        {
            string result = string.Empty;

            switch (OperationCode)
            {
                case Operations.OperationCode.PRODUCT_OUT:
                    result = ((DataRowView)dcbPriceSelect.SelectedItem)["ColumnName"].ToString();
                    break;
                default:
                    result = "price";
                    break;
            }

            return result;
        }

        private void bSaveDoc_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SaveDoc();
            this.Cursor = Cursors.Default;
        }

        private void SaveDoc()
        {
            Print.PrintDocumentHandler print = new Print.PrintDocumentHandler();
            print.SaveDoc(PopulateHeadToPrint(), tableResult, OperationCode);
        }

        private Dictionary<string, string> PopulateHeadToPrint()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("#Customer#", dcbCustomer.Text);
            result.Add("#DocumentDate#", dtpDocDate.Value.ToShortDateString());
            result.Add("#code#", dtbCode.Text);
            return result;
        }

        private void bPrintDoc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Распечатать документ?", "Печать документа", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    this.Cursor = Cursors.WaitCursor;
                    PrintDoc();
                    this.Cursor = Cursors.Default;
                    break;
            }
        }

        private void PrintDoc()
        {
            Print.PrintDocumentHandler print = new Print.PrintDocumentHandler();
            print.PrintDoc(PopulateHeadToPrint(), tableResult, OperationCode);
        }

        private void bUpload_Click(object sender, EventArgs e)
        {
            string priceColumnName = GetPriceColumn();
            ImportTable.ImportTableFromTable importTableFromTable = new ImportTable.ImportTableFromTable(tableResult, tmcView, priceColumnName, OperationCode);

            CalculateDocument();
        }

        private void bReCalculatedDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
