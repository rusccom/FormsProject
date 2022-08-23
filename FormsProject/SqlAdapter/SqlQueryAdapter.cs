using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProject.SqlAdapter
{
    public static class SqlQueryAdapter
    {
        static public bool UpdateRow(Dictionary<string, string> data, int id, Operations.OperationCode operationCode)
        {
            bool result = false;

            string tableName = GetTableName(operationCode);
            string where = WhereConstructor("id", "=", id.ToString());
            AddSQLDefaultValue(data);
            result = DataProject.Scripts.UpdateQuery.UpdateRowById(tableName, data, where, AppInstance.sqlConnection);
            return result;
        }

        public static Tuple<int, bool> InsertSQLData(Dictionary<string, string> data, Operations.OperationCode operationCode)
        {
            string tableName = GetTableName(operationCode);
            AddSQLDefaultValue(data);
            Tuple<int, bool> result = DataProject.Scripts.InsertQuery.InsertRow(tableName, data, AppInstance.sqlConnection);

            return result;
        }

        public static bool DeleteRowById(int id, Operations.OperationCode operationCode)
        {
            bool result = false;
            string tableName = GetTableName(operationCode);
            string where = WhereConstructor("id", " = ", id.ToString());
            result = DataProject.Scripts.DeleteQuery.DeleteRowById(tableName, where, AppInstance.sqlConnection);
            return result;
        }

        static public Dictionary<string, string> GetRowbyId(Operations.OperationCode operationCode, int id)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string tableName = GetTableName(operationCode);
            string where = WhereConstructor("id", "=", id.ToString());

            DataSet dataSet = null;
            dataSet = DataProject.Scripts.SelectQuery.GetTableByTableNameWhere(tableName, where, AppInstance.sqlConnection);

            foreach(DataColumn column in dataSet.Tables[0].Columns)
            {
                string value = dataSet.Tables[0].Rows[0][column].ToString();
                data.Add(column.ColumnName, value);
            }

            return data;
        }

        static public DataSet GetTable(string tableName)
        {
            DataSet result;
            result = DataProject.Scripts.SelectQuery.GetTableByTableName(tableName, AppInstance.sqlConnection);
            return result;
        }

        static public DataSet GetTable(string tableName, string where)
        {
            DataSet result;
            result = DataProject.Scripts.SelectQuery.GetTableByTableNameWhere(tableName, where, AppInstance.sqlConnection);
            return result;
        }

        static public string WhereConstructor(string field, string operation, string value)
        {
            string result;

            result = " where " + field + operation + value;

            return result;
        }

        static private void AddSQLDefaultValue(Dictionary<string, string> data)
        {
            int loginID = AppInstance.UserId;
            data["LoginId"] = loginID.ToString();
            data["CreateDate"] = "'" + DateTime.Now.ToShortDateString() + "'";
        }

        static private string GetTableName(Operations.OperationCode operationCode)
        {
            string tableName = Operations.Operation.GetTableNameByOperationCode(operationCode);
            return tableName;
        }
    }
}
