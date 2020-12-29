using DictionaryDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class FeedBackDAO : DBConnection
    {
        public FeedBackDAO() : base() { }


        private string pushFeedBackCommand = "INSERT INTO tbFeedBack VALUES (@Email, @FullName, @PhoneNumber, @Content)";
        private string getAllFeedBacksCommand = "SELECT * FROM tbFeedBack ORDER BY FeedBackTime DESC";
        private string deleteFeedBackCommand = "DELETE FROM tbFeedBack WHERE fb_id = @Id";
        public bool pushFeedBack(FeedBackDTO fb)
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
            catch (Exception)
            {
                conn.Close();
            }

            return false;
        }

        public DataTable getAllFeedBacks()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(getAllFeedBacksCommand, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception e)
            {
                conn.Close();
                throw e;
            }
           
        }

        public bool deleteFeedBack(FeedBackDTO fb)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(deleteFeedBackCommand, conn))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = fb.Id;
                    

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception e)
            {
                conn.Close();
                throw e;
            }
        }
    }
}
