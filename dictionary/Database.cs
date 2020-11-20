using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dictionary
{
    static class Database
    {
        private static  int now;
        public static string connString = @"DESKTOP-I4FVPU0\E:\Data.sql;Database=Data;User Id=sa;Password=123456789;";
        public static void connect()
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            string sqlQuery = "SELECT * FROM Data WHERE English=";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
        }      
    }
}
