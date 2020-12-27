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

        public bool feedBack(FeedBackDTO fb)
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

        public bool removeFeedBack(FeedBackDTO fb)
        {
            DialogResult result = MessageBox.Show("Are you sure want to delete this FeedBack?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                return objFeedBack.deleteFeedBack(fb);
            }
            else
                return false;
        }

    }
}
