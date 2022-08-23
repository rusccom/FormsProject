using FormsProject.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProject.TableDataHandler
{
    static public class RateAndPercentColumns
    {
        static public void AddRateAndPercentColumnToTable(TableView tableView)
        {
            DataColumn dataColumnPriceToRate = new DataColumn("columnPriceToRate");
            tableView.GetDataTable.Columns.Add(dataColumnPriceToRate);

            tableView.Columns["columnPriceToRate"].Width = 100;
            tableView.Columns["columnPriceToRate"].ReadOnly = true;
            tableView.Columns["columnPriceToRate"].HeaderText = "Цена по курсу";
            tableView.Columns["columnPriceToRate"].Visible = false;

            DataColumn dataColumnPricePercent = new DataColumn("columnPricePercent");
            tableView.GetDataTable.Columns.Add(dataColumnPricePercent);

            tableView.Columns["columnPricePercent"].Width = 100;
            tableView.Columns["columnPricePercent"].ReadOnly = true;
            tableView.Columns["columnPricePercent"].HeaderText = "Цена -20%";
            tableView.Columns["columnPricePercent"].Visible = false;
        }

        static public void ShowRateAndPercentColumn(TableView tableView, bool isShown)
        {
            if (tableView.Columns.Contains("columnPriceToRate"))
                tableView.Columns["columnPriceToRate"].Visible = isShown;

            if (tableView.Columns.Contains("columnPricePercent"))
                tableView.Columns["columnPricePercent"].Visible = isShown;
        }

        static public void CalculateRateAndPercentColumns(TableView tableView, decimal value, Operations.OperationCode operationCode)
        {
            foreach (DataRow row in tableView.GetDataTable.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    decimal price = GetPriceData(operationCode, row);

                    decimal convertedPrice = price * value;
                    if (tableView.Columns.Contains("columnPriceToRate"))
                        row["columnPriceToRate"] = convertedPrice.ToString("0.000", CultureInfo.InvariantCulture); ;

                    decimal convertedPricePercent = convertedPrice / 1.2m;
                    if (tableView.Columns.Contains("columnPricePercent"))
                        row["columnPricePercent"] = convertedPricePercent.ToString("0.000", CultureInfo.InvariantCulture);
                }
            }
        }

        static private decimal GetPriceData(Operations.OperationCode operationCode, DataRow row)
        {
            decimal result = 0;

            switch(operationCode)
            {
                case Operations.OperationCode.LIST_TMC:
                    decimal price1 = Convert.ToDecimal(row["price1"]);
                    decimal price3 = Convert.ToDecimal(row["price3"]);

                    result = price1 >= price3 ? price1 : price3;
                    break;

                case Operations.OperationCode.PRODUCT_IN:
                case Operations.OperationCode.PRODUCT_OUT:
                    result = Convert.ToDecimal(row["price"]);
                    break;
            }

            return result;
        }
    }
}
