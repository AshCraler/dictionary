using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Dictionary_user
{
    public partial class Bookmark : Form
    {
        #region Variable
        private int page = 0;
        private string language1;
        private string language2;
        private string language3;
        private string language4;
        private string language5;
        private string language6;
        private string language7;
        private string language8;
        private string language9;
        private string language10;
        private string language11;
        private string language12;
        private string language13;
        #endregion
        private void loadData()
        {
            if (Database.acction == "showBookmarkList")
                Database.load("select * from bookmark order by id DESC");
            if (Database.loadData.Rows.Count > 0 + 13 * page)
            {
                labelWord1.Text = Database.loadData.Rows[page * 13]["Word"].ToString();
                labelMeaning1.Text = Database.loadData.Rows[page * 13]["meaning"].ToString();
                language1 = Database.loadData.Rows[page * 13]["languages"].ToString();
                speaker1.Visible = true;
                Bookmark1.Visible = true;
            }
            if (Database.loadData.Rows.Count > 1 + 13 * page)
            {
                labelWord2.Text = Database.loadData.Rows[page * 13 + 1]["Word"].ToString();
                labelMeaning2.Text = Database.loadData.Rows[page * 13 + 1]["meaning"].ToString();
                language2 = Database.loadData.Rows[page * 13 + 1]["languages"].ToString();
                Bookmark2.Visible = true;
                speaker2.Visible = true;
            }
            if (Database.loadData.Rows.Count > 2 + 13 * page)
            {
                labelWord3.Text = Database.loadData.Rows[page * 13 + 2]["Word"].ToString();
                labelMeaning3.Text = Database.loadData.Rows[page * 13 + 2]["meaning"].ToString();
                language3 = Database.loadData.Rows[page * 13 + 2]["languages"].ToString();
                Bookmark3.Visible = true;
                speaker3.Visible = true;
            }
            if (Database.loadData.Rows.Count > 3 + 13 * page)
            {
                labelWord4.Text = Database.loadData.Rows[page * 13 + 3]["Word"].ToString();
                labelMeaning4.Text = Database.loadData.Rows[page * 13 + 3]["meaning"].ToString();
                language4 = Database.loadData.Rows[page * 13 + 3]["languages"].ToString();
                Bookmark4.Visible = true;
                speaker4.Visible = true;
            }
            if (Database.loadData.Rows.Count > 4 + 13 * page)
            {
                labelWord5.Text = Database.loadData.Rows[page * 13 + 4]["Word"].ToString();
                labelMeaning5.Text = Database.loadData.Rows[page * 13 + 4]["meaning"].ToString();
                language5 = Database.loadData.Rows[page * 13 + 4]["languages"].ToString();
                Bookmark5.Visible = true;
                speaker5.Visible = true;
            }
            if (Database.loadData.Rows.Count > 5 + 13 * page)
            {
                labelWord6.Text = Database.loadData.Rows[page * 13 + 5]["Word"].ToString();
                labelMeaning6.Text = Database.loadData.Rows[page * 13 + 5]["meaning"].ToString();
                language6 = Database.loadData.Rows[page * 13 + 5]["languages"].ToString();
                Bookmark6.Visible = true;
                speaker6.Visible = true;
            }
            if (Database.loadData.Rows.Count > 6 + 13 * page)
            {
                labelWord7.Text = Database.loadData.Rows[page * 13 + 6]["Word"].ToString();
                labelMeaning7.Text = Database.loadData.Rows[page * 13 + 6]["meaning"].ToString();
                language7 = Database.loadData.Rows[page * 13 + 6]["languages"].ToString();
                Bookmark7.Visible = true;
                speaker7.Visible = true;
            }
            if (Database.loadData.Rows.Count > 7 + 13 * page)
            {
                labelWord8.Text = Database.loadData.Rows[page * 13 + 7]["Word"].ToString();
                labelMeaning8.Text = Database.loadData.Rows[page * 13 + 7]["meaning"].ToString();
                language8 = Database.loadData.Rows[page * 13 + 7]["languages"].ToString();
                Bookmark8.Visible = true;
                speaker8.Visible = true;
            }
            if (Database.loadData.Rows.Count > 8 + 13 * page)
            {
                labelWord9.Text = Database.loadData.Rows[page * 13 + 8]["Word"].ToString();
                labelMeaning9.Text = Database.loadData.Rows[page * 13 + 8]["meaning"].ToString();
                language9 = Database.loadData.Rows[page * 13 + 8]["languages"].ToString();
                Bookmark9.Visible = true;
                speaker9.Visible = true;
            }
            if (Database.loadData.Rows.Count > 9 + 13 * page)
            {
                labelWord10.Text = Database.loadData.Rows[page * 13 + 9]["Word"].ToString();
                labelMeaning10.Text = Database.loadData.Rows[page * 13 + 9]["meaning"].ToString();
                language10 = Database.loadData.Rows[page * 13 + 9]["languages"].ToString();
                Bookmark10.Visible = true;
                speaker10.Visible = true;
            }
            if (Database.loadData.Rows.Count > 10 + 13 * page)
            {
                labelWord11.Text = Database.loadData.Rows[page * 13 + 10]["Word"].ToString();
                labelMeaning11.Text = Database.loadData.Rows[page * 13 + 10]["meaning"].ToString();
                language11 = Database.loadData.Rows[page * 13 + 11]["languages"].ToString();
                Bookmark11.Visible = true;
                speaker11.Visible = true;
            }
            if (Database.loadData.Rows.Count > 11 + 13 * page)
            {
                labelWord12.Text = Database.loadData.Rows[page * 13 + 11]["Word"].ToString();
                labelMeaning12.Text = Database.loadData.Rows[page * 13 + 11]["meaning"].ToString();
                language12 = Database.loadData.Rows[page * 13 + 11]["languages"].ToString();
                Bookmark12.Visible = true;
                speaker12.Visible = true;
            }
            if (Database.loadData.Rows.Count > 12 + 13 * page)
            {
                labelWord13.Text = Database.loadData.Rows[page * 13 + 12]["Word"].ToString();
                labelMeaning13.Text = Database.loadData.Rows[page * 13 + 12]["meaning"].ToString();
                language13 = Database.loadData.Rows[page * 13 + 12]["languages"].ToString();
                Bookmark13.Visible = true;
                speaker13.Visible = true;
            }
        }           
        public Bookmark()
        {
            InitializeComponent();
            loadData();
        }

        private void speaker1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();  
            synth.SetOutputToDefaultAudioDevice();
            if (language1 == "English")
                synth.Speak(labelWord1.Text);
            else synth.Speak(labelMeaning1.Text);       
        }

        private void speaker2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language2 == "English")
                synth.Speak(labelWord2.Text);
            else synth.Speak(labelMeaning2.Text);
        }

        private void speaker3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language3 == "English")
                synth.Speak(labelWord3.Text);
            else synth.Speak(labelMeaning3.Text);
        }

        private void speaker4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language4 == "English")
                synth.Speak(labelWord4.Text);
            else synth.Speak(labelMeaning4.Text);
        }

        private void speaker5_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language5 == "English")
                synth.Speak(labelWord5.Text);
            else synth.Speak(labelMeaning5.Text);
        }

        private void speaker6_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language6 == "English")
                synth.Speak(labelWord6.Text);
            else synth.Speak(labelMeaning6.Text);
        }

        private void speaker7_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language7 == "English")
                synth.Speak(labelWord7.Text);
            else synth.Speak(labelMeaning7.Text);
        }

        private void speaker8_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language8 == "English")
                synth.Speak(labelWord8.Text);
            else synth.Speak(labelMeaning8.Text);
        }

        private void speaker9_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language9 == "English")
                synth.Speak(labelWord9.Text);
            else synth.Speak(labelMeaning9.Text);
        }

        private void speaker10_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language10 == "English")
                synth.Speak(labelWord10.Text);
            else synth.Speak(labelMeaning10.Text);
        }

        private void speaker11_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language11 == "English")
                synth.Speak(labelWord11.Text);
            else synth.Speak(labelMeaning11.Text);
        }

        private void speaker12_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language12 == "English")
                synth.Speak(labelWord12.Text);
            else synth.Speak(labelMeaning12.Text);
        }

        private void speaker13_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language13 == "English")
                synth.Speak(labelWord13.Text);
            else synth.Speak(labelMeaning13.Text);
        }
    }
}
