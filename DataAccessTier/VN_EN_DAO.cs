﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryDTO;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessTier
{
    public class VN_EN_DAO : DBConnection
    {
        private string getVnWordCommand = "SELECT * FROM tbVietAnh WHERE VNKey = @VNKey";
        private string bookMarkCommand = "INSERT INTO tbVNBookMarked VALUES (@VNKey, @VNSuggestion, @WordType, @ENMeans, @Example)";
        private string unMarkCommand = "DELETE FROM tbVNBookMarked WHERE VNKey = @VNKey";
        private string saveWordCommand = "INSERT INTO tbVNHistory VALUES (@Time, @VNKey, @VNSuggestion, @WordType, @ENMeans, @Example)";
        private string addWordCommand = "INSERT INTO tbVietAnh VALUES (@VNKey, @VNSuggestion, @WordType, @ENMeans, @Example)";
        private string deleteHistoryCommand = "DELETE FROM tbVNHistory";
        private string updateWordCommand = "UPDATE tbAnhViet SET VNKey = @VNKey, VNSuggestion = @VNSuggestion, WordType = @WordType, ENMeans = @ENMeans, Example = @Example WHERE VNKey = @key";

        public VN_EN_DAO() : base() { }

        public VN_EN_Word getWord(string key)
        {
            VN_EN_Word w = null;
            
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(getVnWordCommand, conn))
                {
                    cmd.Parameters.Add("@VNKey", SqlDbType.NVarChar).Value = HexadecimalEncoding.ToHexString(key + " \r");

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        w = new VN_EN_Word();

                        w.VNKey = HexadecimalEncoding.FromHexString(sdr["VNKey"].ToString());
                        w.VNSuggestion = sdr["VNSuggestion"].ToString();
                        w.WordType = sdr["WordType"].ToString();
                        w.Means = sdr["ENMeans"].ToString();
                        w.Example = sdr["Example"].ToString();
                    }
                    else
                        sdr.Close();

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@VNKey", SqlDbType.NVarChar).Value = HexadecimalEncoding.ToHexString(key + "\r");
                    sdr = cmd.ExecuteReader();

                    if(sdr.Read())
                    {
                        w = new VN_EN_Word();

                        w.VNKey = HexadecimalEncoding.FromHexString(sdr["VNKey"].ToString());
                        w.VNSuggestion = sdr["VNSuggestion"].ToString();
                        w.WordType = sdr["WordType"].ToString();
                        w.Means = sdr["ENMeans"].ToString();
                        w.Example = sdr["Example"].ToString();
                    }
                    sdr.Close();
                    
                }
            }
            catch(Exception e)
            {
                conn.Close();
                throw e;
            }

            return w;
        }

        public bool bookMark(VN_EN_Word w)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(bookMarkCommand, conn))
                {
                    cmd.Parameters.Add("@VNKey", SqlDbType.NVarChar).Value = w.VNKey;
                    cmd.Parameters.Add("@VNSuggestion", SqlDbType.NVarChar).Value = w.VNSuggestion;
                    cmd.Parameters.Add("@WordType", SqlDbType.NVarChar).Value = w.WordType;
                    cmd.Parameters.Add("@ENMeans", SqlDbType.NText).Value = w.Means;
                    cmd.Parameters.Add("@Example", SqlDbType.NText).Value = w.Example;

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

        public bool unMark(string key)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(unMarkCommand, conn))
                {
                    cmd.Parameters.Add("@VNKey", SqlDbType.NVarChar).Value = key;
                    
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
        public void saveWord(VN_EN_Word w, DateTime t)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(saveWordCommand, conn))
                {
                    cmd.Parameters.Add("@Time", SqlDbType.SmallDateTime).Value = t;
                    cmd.Parameters.Add("@VNKey", SqlDbType.NVarChar).Value = w.VNKey;
                    cmd.Parameters.Add("@VNSuggestion", SqlDbType.NVarChar).Value = w.VNSuggestion;
                    cmd.Parameters.Add("@WordType", SqlDbType.NVarChar).Value = w.WordType;
                    cmd.Parameters.Add("@ENMeans", SqlDbType.NText).Value = w.Means;
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

        public void addWord(VN_EN_Word w)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(addWordCommand, conn))
                {
                    cmd.Parameters.Add("VNKey", SqlDbType.NVarChar).Value = w.VNKey;
                    cmd.Parameters.Add("@VNSuggestion", SqlDbType.NVarChar).Value = w.VNSuggestion;
                    cmd.Parameters.Add("@WordType", SqlDbType.NVarChar).Value = w.WordType;
                    cmd.Parameters.Add("@ENMeans", SqlDbType.NText).Value = w.Means;
                    cmd.Parameters.Add("@Example", SqlDbType.NText).Value = w.Example;

                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }
        }
        //delete all history
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

        public void updateWord(string key, VN_EN_Word w)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(addWordCommand, conn))
                {
                    cmd.Parameters.Add("VNKey", SqlDbType.NVarChar).Value = w.VNKey;
                    cmd.Parameters.Add("@VNSuggestion", SqlDbType.NVarChar).Value = w.VNSuggestion;
                    cmd.Parameters.Add("@WordType", SqlDbType.NVarChar).Value = w.WordType;
                    cmd.Parameters.Add("@ENMeans", SqlDbType.NText).Value = w.Means;
                    cmd.Parameters.Add("@Example", SqlDbType.NText).Value = w.Example;
                    cmd.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;

                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }
        }
    }
}
