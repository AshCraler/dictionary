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
    public partial class MainForm : Form
    {
        DictionaryManager myDictionary;
       
        public MainForm()
        {
            InitializeComponent();

            myDictionary = new DictionaryManager();
            
            myDictionary.loadFirstDataToSuggestionPanel(suggestedWordComboBox);

            this.Controls.Add(myDictionary.VN);
            this.Controls.Add(myDictionary.EN);          
        }

        
        private void optionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            myDictionary.changeStatus();

            if (myDictionary.getStatus()==false)
            {
                translateButton.Text = "Translate";
                
                suggestedWordComboBox.DisplayMember = "Meaning";
            }
            else
            {
                translateButton.Text = "Dịch";
                
                suggestedWordComboBox.DisplayMember = "Key";
            }
            
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            if (wordTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ cần tra vào chỗ trống!\nPlease insert the word that needs to be translated!");
            }
            else
            {
                WordData result = myDictionary.Item.Data.Find(x => x.Key == wordTextBox.Text);
                if (result == null)
                {
                    MessageBox.Show("No words found! I'm sorry.");
                }
                else
                {
                    meaningRichTextBox.Text = result.Meaning + "\n";
                    meaningRichTextBox.Text += result.Explaination;
                }
            }
        }

        private void suggestedWordComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.DataSource == null)
                return;

            WordData data = cb.SelectedItem as WordData;

            meaningRichTextBox.Text = data.Meaning + "\n";
            meaningRichTextBox.Text += data.Explaination;
            
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myDictionary.serialize();
        }

        private void speakButton_Click(object sender, EventArgs e)
        {
            if(wordTextBox.Text=="")
            {
                MessageBox.Show("Vui lòng nhập từ cần tra vào chỗ trống!\nPlease insert the word that needs to be translated!");
            }
            if(myDictionary.getStatus() == true)
            {
                //EN
                myDictionary.myVoice.speak(myDictionary.EN, wordTextBox.Text);
            }
            else
            {
                //VN
                myDictionary.myVoice.speak(myDictionary.VN, wordTextBox.Text);
            }
        }

        private void wordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
