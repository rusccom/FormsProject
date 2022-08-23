using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using FormsProject.Controls;
using System.Drawing;

namespace FormsProject.Forms.Documents.ImportTable
{
    public class ImportTableFromTable
    {
        public ImportTableFromTable(TableView tableResult, TmcView tmcView, string priceColumnName, Operations.OperationCode operationCode)
        {
            string filePath = OpenFile();
            if (!string.IsNullOrEmpty(filePath))
            {
                Aspose.Cells.Workbook workBook = GetWorkbook(filePath);
                string errorList = string.Empty;

                switch (operationCode)
                {
                    case Operations.OperationCode.PRODUCT_IN:
                        ///Новый импорт который использует форму для клиента
                        //DataTable dataTable = GetDataFromExcel(workBook);
                        //Dictionary<string, string> tableColumns = SaveTableDocumentItem.GetColumnsList(Operations.OperationCode.TMC, true);
                        //FormImportTable formImportTable = new FormImportTable(dataTable, tableColumns);
                        //formImportTable.Show();

                        errorList = PopulateData(tableResult, tmcView, priceColumnName, workBook, operationCode);
                        if (!string.IsNullOrEmpty(errorList))
                        {
                            MessageBox.Show("Не удалось загрузить следующте артикула: \r\n " + errorList, "Некоторые строки не удалось загрузить", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        break;

                    case Operations.OperationCode.PRODUCT_OUT:
                        errorList = PopulateData(tableResult, tmcView, priceColumnName, workBook, operationCode);
                        if(!string.IsNullOrEmpty(errorList))
                        {
                            MessageBox.Show("Не удалось загрузить следующте артикула: \r\n " + errorList, "Некоторые строки не удалось загрузить", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }
            }

        }

        private int GetColumnIndex(Aspose.Cells.Worksheet worksheet, int rowIndex, string findText)
        {

            int result = -1;

            for (int i = 0; i < worksheet.Cells.Columns.Count; i++)
            {
                string value = Convert.ToString(worksheet.Cells[rowIndex, i].Value);

                if (string.Compare(value, findText) == 0)
                {
                    result = i;
                    break;
                }
            }
                                   

            //int colIndex = 0;
            //string value = Convert.ToString(worksheet.Cells[rowIndex, colIndex].Value);

            //while(!string.IsNullOrEmpty(value))
            //{
            //    if(string.Compare(value, findText) == 0)
            //    {
            //        result = colIndex;
            //        break;
            //    }
            //    colIndex++;
            //    value = Convert.ToString(worksheet.Cells[rowIndex, colIndex].Value);
            //}

            return result;
        }

        private string PopulateData(TableView tableResult, TmcView tmcView, string priceColumnName, Aspose.Cells.Workbook workBook, Operations.OperationCode operationCode)
        {
            string errorList = string.Empty;
            
            Aspose.Cells.Worksheet workSheet = workBook.Worksheets[0];

            int rowIndex = 3;
            int idColumn = GetColumnIndex(workSheet, rowIndex, "№");
            int quantityColumn = GetColumnIndex(workSheet, rowIndex, "Кол-во\n\n");
            int priceColumn = GetColumnIndex(workSheet, rowIndex, "цена");

            rowIndex = 5;

            if (idColumn >= 0 && quantityColumn >= 0)
            {
                string idValueExcel = Convert.ToString(workSheet.Cells[rowIndex, idColumn].Value);
                string quantityValueExcel = Convert.ToString(workSheet.Cells[rowIndex, quantityColumn].Value);

                while (!string.IsNullOrEmpty(idValueExcel) && !string.IsNullOrEmpty(quantityValueExcel))
                {
                    int tmcId = Convert.ToInt32(idValueExcel);
                    decimal quantity = Convert.ToDecimal(quantityValueExcel);

                    DataRow[] dataRow = tmcView.TmcList.GetDataTable.Select("id = " + idValueExcel);

                    if (dataRow.Length > 0)
                    {
                        DataRow row = tableResult.GetDataTable.NewRow();

                        row["TmcId"] = tmcId;
                        row["TmcName"] = dataRow[0]["name"].ToString();
                        row["UnitId"] = dataRow[0]["UnitId"].ToString();

                        decimal price = 0;
                        switch (operationCode)
                        {
                            case Operations.OperationCode.PRODUCT_IN:

                                string priceFromExcel = Convert.ToString(workSheet.Cells[rowIndex, priceColumn].Value);
                                bool isDecimal = decimal.TryParse(priceFromExcel, out price);

                                if(!isDecimal)
                                {
                                    MessageBox.Show("Ошибка в формате цены - " + priceFromExcel + " - будет записана (0)", "Импорт строки.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                                break;

                            default:
                                price = Convert.ToDecimal(dataRow[0][priceColumnName]);
                                break;
                        }

                        
                        row["price"] = price;
                        row["quantity"] = quantity;
                        row["suma"] = quantity * price;

                        tableResult.GetDataTable.Rows.Add(row);

                        ///select row if negative quantity
                        decimal tmcQuantity = Convert.ToDecimal(dataRow[0]["quantity"]);
                        if (quantity > tmcQuantity)
                        {
                            tableResult.Rows[tableResult.Rows.GetLastRow(DataGridViewElementStates.Visible)].DefaultCellStyle.BackColor = Color.LightPink;
                        }
                    }
                    else
                    {
                        errorList += idValueExcel + "  ";
                    }

                    rowIndex++;
                    idValueExcel = Convert.ToString(workSheet.Cells[rowIndex, idColumn].Value);
                    quantityValueExcel = Convert.ToString(workSheet.Cells[rowIndex, quantityColumn].Value);
                }
            }

            return errorList;
        }

        private DataTable GetDataFromExcel(Aspose.Cells.Workbook workBook)
        {
            DataTable dataTable = new DataTable();

            Aspose.Cells.Worksheet workSheet = workBook.Worksheets[0];

            Dictionary<int, string> excelColumns = GetStructExcelTable(workSheet);

            PrepareDataTable(dataTable, excelColumns);

            bool endTable = false;
            for (int i = 1; i < workSheet.Cells.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach(KeyValuePair<int, string> excelColumn in excelColumns)
                {
                    if (workSheet.Cells[i, excelColumn.Key].Value != null && !string.IsNullOrEmpty(workSheet.Cells[i, excelColumn.Key].Value.ToString()))
                    {
                        dataRow[excelColumn.Value] = workSheet.Cells[i, excelColumn.Key].Value;
                    }
                    else
                    {
                        endTable = true;
                        break;
                    }
                }
                if (endTable)
                    break;
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        private void PrepareDataTable(DataTable dataTable, Dictionary<int, string> excelColumns)
        {
            foreach(KeyValuePair<int, string> excelColumn in excelColumns)
            {
                DataColumn column = new DataColumn(excelColumn.Value);
                dataTable.Columns.Add(column);
            }
        }

        private Dictionary<int, string> GetStructExcelTable(Aspose.Cells.Worksheet workSheet)
        {
            Dictionary<int, string> excelColumns = new Dictionary<int, string>();

            int i = 0;
            string value = Convert.ToString(workSheet.Cells[0, i].Value);
            while (!string.IsNullOrEmpty(value))
            {
                excelColumns.Add(i, value);
                i++;
                value = workSheet.Cells[0, i].Value == null ? string.Empty : workSheet.Cells[0, i].Value.ToString();
            }

            return excelColumns;
        }

        private Aspose.Cells.Workbook GetWorkbook(string filePath)
        {
            Aspose.Cells.Workbook workBook = new Aspose.Cells.Workbook(filePath);

            return workBook;
        }
        private string OpenFile()
        {
            string result = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel (*.xlsm) |*.xlsm|Excel 2003 (*.xls) |*.xls|Excel (*.xlsx) |*.xlsx";

            switch (openFileDialog.ShowDialog())
            {
                case DialogResult.OK:
                    result = openFileDialog.FileName;
                    break;
            }

            return result;
        }
    }
}
