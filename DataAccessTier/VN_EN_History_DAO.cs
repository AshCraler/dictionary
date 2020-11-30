using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryDTO;
using System.IO;
using System.Xml.Serialization;

namespace DataAccessTier
{
    public class VN_EN_History_DAO 
    {
        private string historyFilePath = "VN_EN_History.xml";
        public VN_EN_History history;

        public VN_EN_History_DAO()
        {
            history = getHistory();
        }

        private VN_EN_History getHistory()
        {
            FileStream fs = new FileStream(historyFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(VN_EN_History));

            object obj = sr.Deserialize(fs);

            fs.Close();

            return (VN_EN_History)obj;
        }
        
        private void writeHistory()
        {
            FileStream fs = new FileStream(historyFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(VN_EN_History));

            sr.Serialize(fs, history);

            fs.Close();
        }

        private void saveIntoHistory(VN_EN_Word w)
        {
            history.push(w);
        }

        public void autoSave(VN_EN_Word w)
        {
            saveIntoHistory(w);

            writeHistory();
        }

        public void deleteAllHistory()
        {
            File.Delete(historyFilePath);
        }

        public void deleteItem(int order)
        {
            history.data.RemoveAt(order);
            writeHistory();
        }
    }
}
