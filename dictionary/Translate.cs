using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionary
{
    public partial class Translate : Form
    {
        DictionaryManager myDictionary;
        public Translate()
        {
            InitializeComponent();
            myDictionary = new DictionaryManager();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            /*if (MainForm.)
            {
                MessageBox.Show("Vui lòng nhập từ cần tra vào chỗ trống!\nPlease insert the word that needs to be translated!");
            }
            if (myDictionary.getStatus() == true)
            {
                //EN
                myDictionary.myVoice.speak(myDictionary.EN, textboxSearch.Text);
            }
            else
            {
                //VN
                myDictionary.myVoice.speak(myDictionary.VN, textboxSearch.Text);
            }*/
        }
    }
}
