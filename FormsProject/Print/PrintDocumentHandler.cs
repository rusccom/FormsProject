using FormsProject.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Print
{
     public class PrintDocumentHandler
    {
        string stringToPrint = string.Empty;
        string documentContents = string.Empty;

        public void PrintDoc(Dictionary<string, string> controlValues, TableView table, Operations.OperationCode operationCode)
        {
            Aspose.Cells.Workbook workBook = GetWorkBook(controlValues, table, operationCode);

            //Apply different Image / Print options.
            Aspose.Cells.Rendering.ImageOrPrintOptions options = new Aspose.Cells.Rendering.ImageOrPrintOptions();
            options.PrintingPage = Aspose.Cells.PrintingPageType.Default;
            options.AllColumnsInOnePagePerSheet = true;
            Aspose.Cells.Rendering.SheetRender sr = new Aspose.Cells.Rendering.SheetRender(workBook.Worksheets[0], options);
            System.Drawing.Printing.PrinterSettings printSettings = new System.Drawing.Printing.PrinterSettings();
            string strPrinterName = printSettings.PrinterName;
            //Print the sheet.
            sr.ToPrinter(strPrinterName);
        }


        public void SaveDoc(Dictionary<string, string> controlValues, TableView table, Operations.OperationCode operationCode)
        {
            Aspose.Cells.Workbook workBook = GetWorkBook(controlValues, table, operationCode);

            string fileName = GetFileName(controlValues);
            SaveDocument(workBook, fileName);
        }

        private Aspose.Cells.Workbook GetWorkBook(Dictionary<string, string> controlValues, TableView table, Operations.OperationCode operationCode)
        {
            string patternPath = Directory.GetCurrentDirectory();
            patternPath += GetPrintPattern(operationCode);

            Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(patternPath);
            Aspose.Cells.Worksheet worksheet = workbook.Worksheets[0];

            PopulateDocHeader(worksheet, controlValues);
            PopulateTable(worksheet, table);

            return workbook;
        }

        private string GetFileName(Dictionary<string, string> controlValues)
        {
            string result = string.Empty;

            result += controlValues["#code#"];
            result += "-";
            result += controlValues["#Customer#"];

            return result;
        }

        private void SaveDocument(Aspose.Cells.Workbook workBook, string fileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 2003 (*.xls) | *.xls";
            saveFileDialog.FileName = fileName;
            switch (saveFileDialog.ShowDialog())
            {
                case DialogResult.OK:
                    if(saveFileDialog.FileName != "")
                    {
                        workBook.Save(saveFileDialog.FileName);
                    }
                    break;
            }
        }

        private string GetPrintPattern(Operations.OperationCode operationCode)
        {
            string result = string.Empty;
            switch (operationCode)
            {
                case Operations.OperationCode.PRODUCT_OUT:
                    result = "\\Print\\Documents\\PRODUCT_OUT.XLS";
                    break;
                case Operations.OperationCode.PRODUCT_IN:
                    result = "\\Print\\Documents\\PRODUCT_IN.XLS";
                    break;
            }

            return result;
        }

        private void PopulateTable(Aspose.Cells.Worksheet worksheet, TableView table)
        {
            Dictionary<string, int[,]> dataMap = TableMapping(worksheet, table);
            int rowIndex = dataMap.ElementAt(1).Value[0, 0];

            decimal total = 0;

            foreach (DataGridViewRow dataRow in table.Rows)
            {

                foreach (KeyValuePair<string, int[,]> mapSheet in dataMap)
                {
                    var value = dataRow.Cells[mapSheet.Key.Trim(new char[] { '[', ']' })].Value;
                    worksheet.Cells[rowIndex, mapSheet.Value[0, 1]].Value = value;
                    if(mapSheet.Key == "[suma]")
                    {
                        total += (decimal) value;
                    }
                }
                rowIndex++;
                worksheet.Cells.InsertRow(rowIndex);
                worksheet.Cells.CopyRow(worksheet.Cells, rowIndex + 1, rowIndex);
            }

            worksheet.Cells.DeleteRows(rowIndex, 2);

            worksheet.Cells[rowIndex, dataMap["[suma]"][0,1]].Value = total;
            worksheet.Cells[rowIndex, dataMap["[suma]"][0, 1]-1].Value = "Всего:";
        }

        private Dictionary<string, int[,]> TableMapping(Aspose.Cells.Worksheet worksheet, TableView table)
        {
            Aspose.Cells.FindOptions findOptions = new Aspose.Cells.FindOptions();

            Aspose.Cells.Cell tableCell = null;
            Dictionary<string, int[,]> dataMap = new Dictionary<string, int[,]>();


            foreach (DataGridViewColumn column in table.Columns)
            {
                string columnName = "[" + column.Name + "]";
                tableCell = worksheet.Cells.Find(columnName, null, findOptions);
                if (tableCell != null)
                    dataMap.Add(columnName, new int[,] { { tableCell.Row, tableCell.Column } });
            }

            return dataMap;
        }

        private void PopulateDocHeader(Aspose.Cells.Worksheet worksheet, Dictionary<string, string> controlValues)
        {
            Aspose.Cells.FindOptions findOptions = new Aspose.Cells.FindOptions();

            foreach (KeyValuePair<string, string> item in controlValues)
            {
                Aspose.Cells.Cell cell = worksheet.Cells.Find(item.Key, null, findOptions);
                cell.Value = item.Value;
            }
        }
    }
}
