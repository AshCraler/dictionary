using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DictionaryDTO;

namespace BusinessLogicTier
{
    public class VN_EN_History_BUS 
    {
        public VN_EN_History_DAO obj_His_DAO = new VN_EN_History_DAO();

        public VN_EN_History getHistory()
        {
            return obj_His_DAO.history;
        }

        public void autoSave(VN_EN_Word w)
        {
            obj_His_DAO.autoSave(w);
        }

        public void deleteHistory()
        {
            obj_His_DAO.deleteAllHistory();
        }

        public bool deleteSpecificItem(int order)
        {
            if (obj_His_DAO.history.data.Count > order)
            {
                obj_His_DAO.deleteItem(order);
                return true;
            }
            return false;
        }
    }
}
