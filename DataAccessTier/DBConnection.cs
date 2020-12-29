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
        
        public string getHelp()
        {
            string content = "";


            return content;
        }
    }
}
