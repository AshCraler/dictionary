﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
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
        public static int selectedIndex;
        public static Dictionary<string,PictureBox> flag;
        public static string language;
        
        public static void setIndex()
        {
            if (language == "English")
                selectedIndex = 0;

            if (language == "French")
                selectedIndex = 1;

            if (language == "German")
                selectedIndex = 2;
            
            if (language == "Spanish")
                selectedIndex = 3;

            if (language == "Portuguese")
                selectedIndex = 4;
            
            if (language == "Russian")
                selectedIndex = 5;

            if (language == "Chinese")
                selectedIndex = 6;
            
            if (language == "Japanese")
                selectedIndex = 7;

        }

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
        
        public static void insertBookBookmark(string book, string link, string savedtime)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO bookbookmark(id,book,link,savedtime) VALUES(@id,@book,@link,@savedtime);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@book", book);
                cmd.Parameters.AddWithValue("@link", link);
                cmd.Parameters.AddWithValue("@savedtime", savedtime);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        
        public static void insertIdiomBookmark(string idiom, string link, string savedtime)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Idiombookmark(id,idiom,link,savedtime) VALUES(@id,@idiom,@link,@savedtime);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@idiom", idiom);
                cmd.Parameters.AddWithValue("@link", link);
                cmd.Parameters.AddWithValue("@savedtime", savedtime);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static void insertLuminaryBookmark(string luminary, string link, string savedtime)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Luminarybookmark(id,luminary,link,savedtime) VALUES(@id,@luminary,@link,@savedtime);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@luminary", luminary);
                cmd.Parameters.AddWithValue("@link", link);
                cmd.Parameters.AddWithValue("@savedtime", savedtime);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static void insertMusicBookmark(string music, string link, string savedtime)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Musicbookmark(id,music,link,savedtime) VALUES(@id,@music,@link,@savedtime);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@music", music);
                cmd.Parameters.AddWithValue("@link", link);
                cmd.Parameters.AddWithValue("@savedtime", savedtime);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static void insertMovieBookmark(string movie, string link, string savedtime)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Moviebookmark(id,movie,link,savedtime) VALUES(@id,@movie,@link,@savedtime);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@movie", movie);
                cmd.Parameters.AddWithValue("@link", link);
                cmd.Parameters.AddWithValue("@savedtime", savedtime);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static void insertBookhistory(string book, string link, string savedtime)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO bookhistory(id,book,link,Time) VALUES(@id,@book,@link,@Time);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@book", book);
                cmd.Parameters.AddWithValue("@link", link);
                cmd.Parameters.AddWithValue("@Time", savedtime);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        
        public static void insertIdiomhistory(string idiom, string link, string Time)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Idiomhistory(id,idiom,link,Time) VALUES(@id,@idiom,@link,@Time);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@idiom", idiom);
                cmd.Parameters.AddWithValue("@link", link);
                cmd.Parameters.AddWithValue("@Time", Time);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static void insertLuminaryhistory(string luminary, string link, string Time)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Luminaryhistory(id,luminary,link,Time) VALUES(@id,@luminary,@link,@Time);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@luminary", luminary);
                cmd.Parameters.AddWithValue("@link", link);
                cmd.Parameters.AddWithValue("@Time", Time);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static void insertMusichistory(string music, string link, string Time)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Musichistory(id,music,link,Time) VALUES(@id,@music,@link,@Time);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@music", music);
                cmd.Parameters.AddWithValue("@link", link);
                cmd.Parameters.AddWithValue("@Time", Time);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static void insertMoviehistory(string movie, string link, string Time)
        {
            string connectionString = @"server=localhost;userid=root;password=MyNewPass;database=sql_invoicing";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Moviehistory(id,movie,link,Time) VALUES(@id,@movie,@link,@Time);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@movie", movie);
                cmd.Parameters.AddWithValue("@link", link);
                cmd.Parameters.AddWithValue("@Time", Time);
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
