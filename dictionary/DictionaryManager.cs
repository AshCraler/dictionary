using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomizeControl;
using System.IO;
using System.Xml.Serialization;

namespace dictionary
{
    public class DictionaryManager
    {
        #region properties

        private string dictionaryDataPath = "data.xml";
        private string demoDataPath = "data.xml";
        private DictionaryItem item;
        private bool isStatusEN_VN;
        public static string vietnameseSpeakerSource;
        public static string englishSpeakerSource;
        public Speaker myVoice = new Speaker();

        public WebBrowser VN = new WebBrowser();
        public WebBrowser EN = new WebBrowser();

        public DictionaryItem Item
        {
            get { return item; }
            set { item = value; }
        }

        #endregion

        #region methods
        public void changeStatus()
        {
            isStatusEN_VN = !isStatusEN_VN;
        }
        public bool getStatus()
        {
            return isStatusEN_VN;
        }

        public DictionaryManager()
        {
            isStatusEN_VN = true;
            item = (DictionaryItem)deserializeFromXML(dictionaryDataPath);
            VN.Width = 0;
            VN.Height = 0;
            VN.Visible = false;
            VN.ScriptErrorsSuppressed = true;
            VN.Navigate("https://responsivevoice.org/text-to-speech-languages/van-ban-de-noi-trong-tieng-viet/");

            EN.Width = 0;
            EN.Height = 0;
            EN.Visible = false;
            EN.ScriptErrorsSuppressed = true;
            EN.Navigate("https://responsivevoice.org/text-to-speech-languages/us-english-text-to-speech/");
        }

        private DictionaryItem suggestedItems()
        {
            //function content
            /*filestream(dictionaryDataPath,...) is used by another process, this function have to
            work on the item
             */
            FileStream fs = new FileStream(demoDataPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem)); 
            DictionaryItem result = (DictionaryItem)sr.Deserialize(fs);
            fs.Close();
            return result;
        }
        
        public void loadFirstDataToSuggestionPanel(ComboBox inputComboBox)
        {
            //function content
      //      inputComboBox.DataSource = suggestedItems().Data;
     //       inputComboBox.DisplayMember = "Key";
            
            
        }

        private void serializeToXML(object data, string dataFilePath)
        {
            //function content
            FileStream fs = new FileStream(dataFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            sr.Serialize(fs, data);

            fs.Close();
        }

        public void serialize()
        {
            serializeToXML(item, dictionaryDataPath);
        }

        public object deserializeFromXML(string dataFilePath)
        {
            //function content
            FileStream fs = new FileStream(dataFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            object obj = sr.Deserialize(fs);

            
            fs.Close();
            return obj;
        }

        #endregion
    }
}
