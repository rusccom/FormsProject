using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject.Scripts
{
    static public class DeleteQuery
    {
        static public bool DeleteRowById(string tableName, string where, SqlConnection sqlConnection)
        {
            bool result = false;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "delete from " + tableName + where;

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
