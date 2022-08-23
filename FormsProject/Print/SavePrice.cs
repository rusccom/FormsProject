using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Print
{
    public class SavePrice
    {
        public void Save()
        {
            Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook();

            DataTable priceTable = SqlAdapter.SqlQueryAdapter.GetTable("TmcView").Tables[0];
            DataTable groupTable = SqlAdapter.SqlQueryAdapter.GetTable("TmcGroup" , " order by [name] ASC").Tables[0];

            foreach (DataRow row in groupTable.Rows)
            {
                string groupName = row["name"].ToString();

                DataRow[] priceRow = priceTable.Select("GroupId = '" + groupName + "'", "[name] ASC");

                if (priceRow.Length > 0)
                {
                    if (groupName.Length>31)
                    groupName = groupName.Remove(31, groupName.Length - 31);

                    Aspose.Cells.Worksheet worksheet = workbook.Worksheets.Add(groupName);

                    SetColumnName(worksheet);

                    int rowIndex = 1;
                    foreach (DataRow dataRow in priceRow)
                    {
                        worksheet.Cells[rowIndex, 0].Value = dataRow["id"].ToString();
                        worksheet.Cells[rowIndex, 1].Value = dataRow["name"].ToString();
                        worksheet.Cells[rowIndex, 2].Value = dataRow["UnitId"].ToString();
                        worksheet.Cells[rowIndex, 3].Value = dataRow["GroupId"].ToString();
                        worksheet.Cells[rowIndex, 4].Value = dataRow["price"].ToString();
                        worksheet.Cells[rowIndex, 5].Value = dataRow["price1"].ToString();
                        worksheet.Cells[rowIndex, 6].Value = dataRow["price2"].ToString();
                        worksheet.Cells[rowIndex, 7].Value = dataRow["price3"].ToString();
                        worksheet.Cells[rowIndex, 8].Value = dataRow["quantity"].ToString();
                        rowIndex++;
                    }
                }

            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 2003 (*.xls) | *.xls";

            switch(saveFileDialog.ShowDialog())
            {
                case DialogResult.OK:
                    workbook.Save(saveFileDialog.FileName);
                    break;
            }
        }

        private void SetColumnName(Aspose.Cells.Worksheet worksheet)
        {
            worksheet.Cells[0, 0].Value = "Артикул";
            worksheet.Cells[0, 1].Value = "Наименование";
            worksheet.Cells[0, 2].Value = "Ед. Изм.";
            worksheet.Cells[0, 3].Value = "Группа";
            worksheet.Cells[0, 4].Value = "Цена";
            worksheet.Cells[0, 5].Value = "Цена1";
            worksheet.Cells[0, 6].Value = "Цена2";
            worksheet.Cells[0, 7].Value = "Цена3";
            worksheet.Cells[0, 8].Value = "Количество";
        }
    }
}
