using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataProject.Log;

namespace DataProject.SqlDataBase
{
    static public class Connection
    {

        static public Exception exception;

        //static private string connectionString = string.Empty;

        static public SqlConnection Open(string connectionStr = "")
        {
            //if (connectionString == string.Empty)
            //{
            //    connectionString = connectionStr;
            //}

            SqlConnection sqlConnection = new SqlConnection(connectionStr);

            try
            {
                sqlConnection.Open();
                Scripts.InsertQuery.ExcecuteSqlQuery("set dateformat dmy", sqlConnection);
            }
            catch (Exception exc)
            {
                exception = exc;
                LogHandler.SetException(exception);
            }

            return sqlConnection;
        }
    }

    
}
