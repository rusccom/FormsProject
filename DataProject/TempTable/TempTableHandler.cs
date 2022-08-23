using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject.TempTable
{
    static public class TempTableHandler
    {
        static public void CreateTempTable(int userId, SqlConnection connection)
        {
            string query = "create table ##" + userId + " (id int, operationCode int)";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteReader();
        }

        static public bool IsTableExist(int userId, SqlConnection connection)
        {
            bool result = false;

            SqlCommand sqlCommand = new SqlCommand("select Object_ID('tempdb..##" + userId + "')", connection);
            object userTable = sqlCommand.ExecuteScalar();

            //bool qwe = Convert.ToBoolean(userTable);

            if(userTable != DBNull.Value)
            {
                result = true;
            }

            return result;
        }

        static public void SetValueToTempTable(int userId, int id, int operationCode, SqlConnection connection)
        {
            string query = "IF NOT EXISTS (SELECT id FROM ##" + userId + " WHERE id = " + id + " AND operationCode = " + operationCode + ") BEGIN INSERT into ##" + userId + " values (" + id + ", " + operationCode + ") END;";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
        }

        static public void DeleteValueFromTempTable(int userId, int id, int operationCode, SqlConnection connection)
        {
            Scripts.DeleteQuery.DeleteRowById("##" + userId, " where id = " + id + " and operationCode = " + operationCode, connection);
        }

        static public bool GetValueFromTempTable(int id, int operationCode, SqlConnection connection)
        {
            bool result = false;

            DataTable usersTable = Scripts.SelectQuery.GetTableByTableName("system.login", connection).Tables[0];

            string sqlQuery = string.Empty;

            foreach (DataRow row in usersTable.Rows)
            {
                int userIdFromDB = (int)row["id"];
                //if (userIdFromDB != UserId)
                //{
                    sqlQuery += "IF OBJECT_ID('tempdb..##" + userIdFromDB + "') IS NOT NULL select id from ##" + userIdFromDB + " where operationCode = " + operationCode + " and id = " + id + ";";
                //}
            }

            object isBusi = null;
            if (sqlQuery != string.Empty)
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                isBusi = command.ExecuteScalar();
            }

            result = isBusi == null ? false : true;

            return result;
        }
    }
}
