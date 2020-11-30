using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DictionaryDTO;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class FeedBack_BUS
    {
        public FeedBackDAO objFeedBack = new FeedBackDAO();

        public bool feedBack(FeedBack fb)
        {
            if (objFeedBack.pushFeedBack(fb) == false)
            {
                MessageBox.Show("FeedBack failed");
                return false;
            }
            else
                return true;
                
        }

        public DataTable allFeedBacks()
        {
            return objFeedBack.getAllFeedBacks();
        }

    }
}
