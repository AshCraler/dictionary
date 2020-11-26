using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryDTO;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessTier
{
    public class EN_VN_DAO : DBConnection
    {
        private string getEnWordCommand = "SELECT FROM tbAnhViet WHERE ENKey = @ENKey";
        private string bookMarkCommand = "INSERT INTO tbENBookMark VALUES(@ENKey, @Pronounciation, @WordType, @VNMean, @Example)";
        private string unMarkCommand = "DELETE FROM tbENBookMark WHERE ENKey = @ENKey";
        private string saveWordCommand = "INSERT INTO tbENHistory VALUES (@Time, @ENKey, @Pronounciation, @WordType, @VNMean, @Example)";
        private string deleteHistoryCommand = "DELETE FROM tbENHistory";

        public EN_VN_DAO() : base() { }

        public EN_VN_Word getWord(string key)
        {
            EN_VN_Word w = null;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(getEnWordCommand, conn))
                {
                    cmd.Parameters.Add("@ENKey", SqlDbType.VarChar).Value = key;

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if(sdr.Read())
                    {
                        w = new EN_VN_Word();
                        w.ENKey = sdr["ENKey"].ToString();
                        w.Pronounciation = sdr["Pronounciation"].ToString();
                        w.WordType = sdr["WordType"].ToString();
                        w.Means = sdr["VNMean"].ToString();
                        w.Example = sdr["Example"].ToString();

                        sdr.Close();
                    }
                 }
            }
            catch(Exception e)
            {
                conn.Close();
                throw e;
            }

            return w;
        }

        public bool bookMark(EN_VN_Word w)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(bookMarkCommand, conn))
                {
                    cmd.Parameters.Add("@ENKey", SqlDbType.VarChar).Value = w.ENKey;
                    cmd.Parameters.Add("@Pronounciation", SqlDbType.NVarChar).Value = w.Pronounciation;
                    cmd.Parameters.Add("@WordType", SqlDbType.NVarChar).Value = w.WordType;
                    cmd.Parameters.Add("@VNMean", SqlDbType.NText).Value = w.Means;
                    cmd.Parameters.Add("@Example", SqlDbType.NText).Value = w.Example;

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

        public bool unMark(string key)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(unMarkCommand, conn))
                {
                    cmd.Parameters.Add("@ENKey", SqlDbType.VarChar).Value = key;

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

        //autosave, is for history
        public void saveWord(EN_VN_Word w, DateTime t)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(saveWordCommand, conn))
                {
                    cmd.Parameters.Add("@Time", SqlDbType.SmallDateTime).Value = t;
                    cmd.Parameters.Add("@ENKey", SqlDbType.VarChar).Value = w.ENKey;
                    cmd.Parameters.Add("@Pronounciation", SqlDbType.NVarChar).Value = w.Pronounciation;
                    cmd.Parameters.Add("@WordType", SqlDbType.NVarChar).Value = w.WordType;
                    cmd.Parameters.Add("@VNMean", SqlDbType.NText).Value = w.Means;
                    cmd.Parameters.Add("@Example", SqlDbType.NText).Value = w.Example;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                conn.Close();
                throw e;
            }
        }

        public void deleteHistory()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(deleteHistoryCommand, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                conn.Close();
                throw e;
            }
        }

    }
}
