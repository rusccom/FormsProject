using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject.Scripts
{
    static public class UpdateQuery
    {
        static public bool UpdateRowById(string tableName, Dictionary<string, string> data, string where, SqlConnection sqlConnection)
        {
            bool result = false;

            string set = string.Empty;

            foreach (KeyValuePair<string, string> fieldValuePair in data)
            {
                set += fieldValuePair.Key + " = " + fieldValuePair.Value + ",";
            }

            set = set.Remove(set.Length - 1, 1);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "update " + tableName + " set "+ set + where;

            try
            {
                sqlCommand.ExecuteNonQuery();
                result = true;
            }
            catch (Exception exc)
            {
                Log.LogHandler.SetException(exc);
            }

            return result;
        }
    }
}
