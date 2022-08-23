//using FormsProject.Controls;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace FormsProject.Forms.Documents.DocItemsHandling
//{
//    public class RowsHandling
//    {
//        public RowsHandling(TableView tableResult, TmcView tmcView)
//        {

//        }

//        public void InsertRow(int tmcId)
//        {
//            FormCount formCount = new FormCount();

//            if (formCount.ShowDialog() == DialogResult.OK)
//            {
//                AddNewRow(tmcId, formCount.Count);
//                tableResult.FirstDisplayedScrollingRowIndex = tableResult.Rows.Count - 1;
//                CalculateDocument();
//            }
//        }
//        private void AddNewRow(int tmcId, decimal quantity)
//        {
//            DataRow[] dataRow = tmcView.TmcList.GetDataTable.Select("id = " + tmcId.ToString());

//            if (dataRow.Length > 1)
//            {
//                MessageBox.Show("Критичиская ошибка, повторяется 'id' ТМЦ.", "Критичиская ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//                return;
//            }

//            if (CheckQuantityTmc(dataRow, quantity))
//            {

//                DataRow row = tableResult.GetDataTable.NewRow();

//                row["TmcId"] = tmcId;
//                row["TmcName"] = dataRow[0]["name"].ToString();
//                row["UnitId"] = dataRow[0]["UnitId"].ToString();

//                string priceColumn = GetPriceColumn();

//                decimal price = (decimal)dataRow[0][priceColumn];
//                row["price"] = price;
//                row["quantity"] = quantity;
//                row["suma"] = quantity * price;

//                tableResult.GetDataTable.Rows.Add(row);
//            }
//        }

//        private bool CheckQuantityTmc(DataRow[] dataRow, decimal quantity)
//        {
//            bool result = true;
//            if (OperationCode != Operations.OperationCode.PRODUCT_IN)
//            {
//                decimal tmcQuantity = (decimal)dataRow[0]["quantity"];

//                if (tmcQuantity < quantity)
//                {
//                    DialogResult dialogResult = MessageBox.Show("На складе не хватает количества, продаем в минус?", "Не хватает количества.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
//                    switch (dialogResult)
//                    {
//                        case DialogResult.No:
//                            result = false;
//                            break;
//                    }
//                }
//            }

//            return result;
//        }
//    }
//}
