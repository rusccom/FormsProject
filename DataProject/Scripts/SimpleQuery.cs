using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataProject.Scripts
{
    static public class SimpleQuery
    {
        static public void ExecuteNonQuery(SqlConnection connection, string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteReader();
        }

        public static bool IsDBExist(string DBName, SqlConnection sqlConnection)
        {
            bool result = false;

                SqlCommand cmd = new SqlCommand($"select DB_ID(N'{DBName}')", sqlConnection);
                object dbVal = cmd.ExecuteScalar();

                if (dbVal != DBNull.Value)
                {
                    result = true;
                }

            return result;
        }

        public static bool CraeteDataBase(string createDBScript, SqlConnection sqlConnection)
        {
            bool result = false;

            SqlCommand command = new SqlCommand(createDBScript, sqlConnection);
            var data = command.BeginExecuteReader();

            return result;
        }
    }
}
