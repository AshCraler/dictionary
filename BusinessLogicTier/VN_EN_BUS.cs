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
    public class VN_EN_BUS
    {
        VN_EN_DAO obj_VN_EN = new VN_EN_DAO();

        public VN_EN_Word searchWord(string s)
        {
            return obj_VN_EN.getWord(s);
        }

        public void bookMarkWord(VN_EN_Word w)
        {
            if (obj_VN_EN.bookMark(w) == false)
                MessageBox.Show("Failed bookmarking");
            else
                return;
        }

        public void unMarkWord(VN_EN_Word w)
        {
            if (obj_VN_EN.unMark(w.VNKey) == false)
                MessageBox.Show("Failed unmarking");
            else
                return;
        }
    }
}
