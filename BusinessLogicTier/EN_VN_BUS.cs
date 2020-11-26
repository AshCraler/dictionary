using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DictionaryDTO;
using System.Windows.Forms;

namespace BusinessLogicTier
{
    public class EN_VN_BUS
    {
        EN_VN_DAO objEN_VN = new EN_VN_DAO();

        public EN_VN_Word searchWord(string s)
        {
            return objEN_VN.getWord(s);
        }

        public void bookMarkWord(EN_VN_Word w)
        {
            if (objEN_VN.bookMark(w) == false)
                MessageBox.Show("Failed");
            else
                return;
        }

        public void unMarkWord(EN_VN_Word w)
        {
            if (objEN_VN.unMark(w.ENKey) == false)
                MessageBox.Show("Failed");
            else
                return;
        }
    }
}
