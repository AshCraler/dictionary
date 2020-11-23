﻿using System;
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
        public static DataSet loadData;
        public static void load(string command)
        {
            string MyConnectionString = "Server=localhost;Database=sql_invoicing;Uid=root;Pwd=MyNewPass";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = command;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                loadData = new DataSet();
                adap.Fill(loadData);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Clone();
                }
            }
        }
    }
}
