using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms
{
   static public class SaveTableDocumentItem
    {
        static public void SaveDocumentItem(DataTable table, Operations.OperationCode operationCode, int documentId)
        {
            Operations.OperationCode itemOperation = GetItemOperationCode(operationCode);

            Dictionary<string, string> listTableColumn = GetColumnsList(itemOperation);

            DataTable tableWithChange = table.GetChanges();
            if (tableWithChange != null)
            {
                foreach (DataRow row in tableWithChange.Rows)
                {
                    int rowId = 0;

                    switch (row.RowState)
                    {
                        case DataRowState.Added:
                            PrepareData(listTableColumn, row, documentId, false);
                            if(!SqlAdapter.SqlQueryAdapter.InsertSQLData(listTableColumn, itemOperation).Item2)
                            {
                                MessageBox.Show("Не удалось сохранить - " + listTableColumn["TmcName"], "Ошибка при сохранении.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        case DataRowState.Deleted:
                            rowId = (int)row["id", DataRowVersion.Original];
                            if(!SqlAdapter.SqlQueryAdapter.DeleteRowById(rowId, itemOperation))
                            {
                                MessageBox.Show("Не удалось удалить строку - " + listTableColumn["TmcName"], "Ошибка при удалении строки.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            break;
                        case DataRowState.Modified:
                            PrepareData(listTableColumn, row, documentId, true);
                            rowId = (int)row["id"];
                            if(!SqlAdapter.SqlQueryAdapter.UpdateRow(listTableColumn, rowId, itemOperation))
                            {
                                MessageBox.Show("Не удалось обновить данные для - " + listTableColumn["TmcName"], "Ошибка при обновлении данных.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        case DataRowState.Detached:
                            break;
                        case DataRowState.Unchanged:
                            break;
                    }
                    HandlerData(row, listTableColumn, itemOperation);
                }
                table.AcceptChanges();
            }
        }

        static private void HandlerData(DataRow row, Dictionary<string, string> listTableColumn, Operations.OperationCode operationCode)
        {
            if (row.RowState != DataRowState.Deleted)
            {
                switch (operationCode)
                {
                    case Operations.OperationCode.PRODUCT_ITEM_IN:
                        //Updata TMC Price when user add new DocumentItemIn
                        Dictionary<string, string> tmcData = new Dictionary<string, string>();
                        int tmcId = Convert.ToInt32(listTableColumn["TmcId"]);
                        string tmcPrice = listTableColumn["price"].ToString();
                        tmcData.Add("price", tmcPrice);
                        if (!SqlAdapter.SqlQueryAdapter.UpdateRow(tmcData, tmcId, Operations.OperationCode.TMC))
                        {
                            MessageBox.Show("Не удалось обновить закупочную цену для - " + listTableColumn["TmcName"], "Ошибка при обновлении закупочной цены.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }
            }
        }

        static private void PrepareData(Dictionary<string, string> listTableColumn, DataRow row, int documentId, bool isUpdate)
        {
            for (int i = 0; i < row.ItemArray.Length; i++)
            {
                string columnName = row.Table.Columns[i].ColumnName;
                if (row[i] != DBNull.Value)
                {
                    if (listTableColumn.ContainsKey(columnName))
                    {
                        listTableColumn[columnName] = row[i].ToString();
                    }
                }
                else
                {
                    switch (row.Table.Columns[i].ColumnName)
                    {
                        case "DocumentId":
                            listTableColumn[columnName] = documentId.ToString();
                            break;
                    }
                }
            }
        }

        static private Operations.OperationCode GetItemOperationCode(Operations.OperationCode operationCode)
        {
            Operations.OperationCode itemOperation = Operations.Operation.GetOperationFormCodeByList(operationCode);

            return itemOperation;
        }

        static public Dictionary<string, string> GetColumnsList(Operations.OperationCode itemOperation, bool includeSystemColumns = false)
        {
            Dictionary<string, string> listTableColumn = new Dictionary<string, string>();

            string tableName = Operations.Operation.GetTableNameByOperationCode(itemOperation);

            DataTable table = SqlAdapter.SqlQueryAdapter.GetTable(tableName, "where id = 0").Tables[0];

            foreach (DataColumn column in table.Columns)
            {
                string columnName = column.ColumnName;
                if (includeSystemColumns || columnName != "id" && columnName != "LoginId" && columnName != "CreateDate")
                    listTableColumn.Add(column.ColumnName, "");
            }

            return listTableColumn;
        }
    }
}
