using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataProject.Scripts
{
    public static class SelectQuery
    {
        public static DataSet GetTableByTableName(string tableName, SqlConnection connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from " + tableName, connection);
            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            return dataset;
        }

        public static DataSet GetTableByTableNameWhere(string tableName, string where, SqlConnection connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from " + tableName + " "+ where, connection);
            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            return dataset;
        }

        public static DataSet GetSelect(string selectQuery, SqlConnection connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, connection);
            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            return dataset;
        }
    }
}
