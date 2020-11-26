using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryDTO;
using System.Data;

namespace DataAccessTier
{

    public class DBConnection
    {
        protected SqlConnection conn;
        public string connectionStr = @"Data Source=ashcraler.database.windows.net;Initial Catalog=Dictionary;Persist Security Info=True;User ID=ashcraler;Password=admin123$%^";
        
        private string pushFeedBackCommand = "INSERT INTO tbFeedBack VALUES (@Email, @FullName, @PhoneNumber, @Content)";
        public DBConnection()
        {
            try
            {
                conn = new SqlConnection(connectionStr);
            }catch(Exception e)
            {
                throw e;
            }
        }

        public bool pushFeedBack(FeedBack fb)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(pushFeedBackCommand, conn))
                {
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = fb.email;
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = fb.fullName;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = fb.phoneNumber;
                    cmd.Parameters.Add("@Content", SqlDbType.NText).Value = fb.content;

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception)
            {
                conn.Close();
            }

            return false;
        }



        public string getHelp()
        {
            string content = "";


            return content;
        }
    }
}
