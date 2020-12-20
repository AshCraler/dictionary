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
        public static string word;
        public static DataTable loadData;
        public static bool setLanguages;
        public static string textboxSearchText;
        public static int BookandMore;
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
        } // Load dữ liệu từ Database
        public static void insertHistory(string word,string meaning,string date,string check,string translate)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO historysearch(id,Word,Meaning,TimeSearch,Bookmark,Translate) VALUES(@id,@Word,@Meaning,@TimeSearch,@Bookmark,@Translate);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@Word", word);
                cmd.Parameters.AddWithValue("@Meaning", meaning);
                cmd.Parameters.AddWithValue("@TimeSearch", date);
                cmd.Parameters.AddWithValue("@Bookmark", check);
                cmd.Parameters.AddWithValue("@Translate", translate);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public static void updateHistory(string command)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";
            MySqlConnection conn = null;
            MySqlTransaction tr = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                tr = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = tr;
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();
                tr.Commit();
            }
            catch (MySqlException ex )
            {
                tr.Rollback();
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        public static void deleteHistory(string command)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public static void insertBookmark(string word, string meaning, string languages, string savedtime)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO bookmark(id,Word,Meaning,languages,savedtime) VALUES(@id,@Word,@Meaning,@languages,@savedtime);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@word", word);
                cmd.Parameters.AddWithValue("@meaning", meaning);
                cmd.Parameters.AddWithValue("@languages", languages);
                cmd.Parameters.AddWithValue("@savedtime", savedtime);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public static void deleteBookmark(string command)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = command;
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
