using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject.Scripts
{
    public static class InsertQuery
    {
        public static Tuple<int, bool> InsertRow(string tableName, Dictionary<string, string> data, SqlConnection sqlConnection)
        {
            bool isSuccess = false;
            int outputId = 0;

            string field = " (";
            string value = " (";

            foreach(KeyValuePair<string, string> fieldValuePair in data)
            //for(int i = 0; i < data.Count; i++)
            {
                field += fieldValuePair.Key + ", ";
                value += fieldValuePair.Value + ", ";
            }

            field = field.Remove(field.Length - 2, 2) + ") ";
            value = value.Remove(value.Length - 2, 2) + ")";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "insert into " + tableName + field + "output INSERTED.ID values" + value;

            try
            {
                outputId = (int) sqlCommand.ExecuteScalar();
                isSuccess = true;
            } catch(Exception exc)
            {
                Log.LogHandler.SetException(exc);
                isSuccess = false;
            }

            return Tuple.Create(outputId, isSuccess);
        }

        public static void ExcecuteSqlQuery(string query, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = query;

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                Log.LogHandler.SetException(exc);
            }
        }

    }
}
