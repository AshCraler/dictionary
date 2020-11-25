using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace Dictionary_user
{
    static class Database
    {
        public static int nowForm;
        public static string acction;
        public static DataTable loadData;
        public static void load(string command)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            MySqlDataReader reader = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand(command, connection);
                DataTable Data = new DataTable();
                loadData = Data;
                dataAdapter.Fill(loadData);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (connection != null)
                    connection.Close();
            }
        }
        public static void insertHistory(string word,string meaning,string date,string check)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO historysearch(id,Word,Meaning,searchDate,Bookmark) VALUES(@id,@Word,@Meaning,@searchDate,@Bookmark);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@Word", word);
                cmd.Parameters.AddWithValue("@Meaning", meaning);
                cmd.Parameters.AddWithValue("@searchDate", date);
                cmd.Parameters.AddWithValue("@Bookmark", check);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
