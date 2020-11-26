﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DictionaryDTO;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class Connection_BUS
    {
        public DBConnection objConn = new DBConnection();

        public void feedBack(FeedBack fb)
        {
            if (objConn.pushFeedBack(fb) == false)
                MessageBox.Show("FeedBack failed");
            else
                return;
        }

        public void getHelp()
        {
            
        }
    }
}
