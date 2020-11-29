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
        private string command;
        public string time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
        private bool[] check = new bool[100000];
        #endregion
        private void loadImageSource()
        {
            engFlag1.Image = Properties.Resources.united_kingdom;
            engFlag2.Image = Properties.Resources.united_kingdom;
            engFlag3.Image = Properties.Resources.united_kingdom;
            engFlag4.Image = Properties.Resources.united_kingdom;
            engFlag5.Image = Properties.Resources.united_kingdom;
            engFlag6.Image = Properties.Resources.united_kingdom;
            engFlag7.Image = Properties.Resources.united_kingdom;
            engFlag8.Image = Properties.Resources.united_kingdom;
            engFlag9.Image = Properties.Resources.united_kingdom;
            engFlag10.Image = Properties.Resources.united_kingdom;
            engFlag11.Image = Properties.Resources.united_kingdom;
            engFlag12.Image = Properties.Resources.united_kingdom;
            engFlag13.Image = Properties.Resources.united_kingdom;

            vieFlag1.Image = Properties.Resources.vietnam;
            vieFlag2.Image = Properties.Resources.vietnam;
            vieFlag3.Image = Properties.Resources.vietnam;
            vieFlag4.Image = Properties.Resources.vietnam;
            vieFlag5.Image = Properties.Resources.vietnam;
            vieFlag6.Image = Properties.Resources.vietnam;
            vieFlag7.Image = Properties.Resources.vietnam;
            vieFlag8.Image = Properties.Resources.vietnam;
            vieFlag9.Image = Properties.Resources.vietnam;
            vieFlag10.Image = Properties.Resources.vietnam;
            vieFlag11.Image = Properties.Resources.vietnam;
            vieFlag12.Image = Properties.Resources.vietnam;
            vieFlag13.Image = Properties.Resources.vietnam;
        }
        
        private void loadDatabase(string cmd)
        {
            if (Database.acction == "showBookmarkList")
                Database.load(cmd);
            for (int i = 0; i < 100000; i++)
                check[i] = true;
        }
        
        private void loadPageInfo()
        {
            string max;
            if ((page + 1) * 13 < Database.loadData.Rows.Count)
                max = ((page + 1) * 13).ToString();
            else max = Database.loadData.Rows.Count.ToString();
            if (Database.loadData.Rows.Count == 0)
                pageInfo.Visible = false;
            else
                pageInfo.Visible = true;
            pageInfo.Text = (page * 13 + 1).ToString() + " - " + max + " / " + Database.loadData.Rows.Count.ToString() + " Vocalbulary";
        }

        private void loadData()
        {   
            loadImageSource();
            loadPageInfo();
            if (Database.loadData.Rows.Count > 0 + 13 * page)
            {
                labelWord1.Visible = true;
                labelMeaning1.Visible = true;
                labelWord1.Text = Database.loadData.Rows[page * 13]["Word"].ToString();
                labelMeaning1.Text = Database.loadData.Rows[page * 13]["meaning"].ToString();
                language1 = Database.loadData.Rows[page * 13]["languages"].ToString();
                speaker1.Visible = true;
                Bookmark1.Visible = true;
                if (check[page*13+1]==true)
                    Bookmark1.IconColor= Color.FromArgb(238, 26, 74);
                else
                    Bookmark1.IconColor = Color.Gainsboro;
                engFlag1.Visible = true;
                vieFlag1.Visible = true;
                if (language1!="English")
                {
                    engFlag1.Image = Properties.Resources.vietnam;
                    vieFlag1.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord1.Visible = false;
                labelMeaning1.Visible = false;
                speaker1.Visible = false;
                Bookmark1.Visible = false;
                engFlag1.Visible = false;
                vieFlag1.Visible = false;
            }
            if (Database.loadData.Rows.Count > 1 + 13 * page)
            {
                labelWord2.Visible = true;
                labelMeaning2.Visible = true;
                labelWord2.Text = Database.loadData.Rows[page * 13 + 1]["Word"].ToString();
                labelMeaning2.Text = Database.loadData.Rows[page * 13 + 1]["meaning"].ToString();
                language2 = Database.loadData.Rows[page * 13 + 1]["languages"].ToString();
                Bookmark2.Visible = true;
                if (check[page * 13 + 2] == true)
                    Bookmark2.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark2.IconColor = Color.Gainsboro;
                speaker2.Visible = true;
                engFlag2.Visible = true;
                vieFlag2.Visible = true;
                if (language2 != "English")
                {
                    engFlag2.Image = Properties.Resources.vietnam;
                    vieFlag2.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord2.Visible = false;
                labelMeaning2.Visible = false;
                speaker2.Visible = false;
                Bookmark2.Visible = false;
                engFlag2.Visible = false;
                vieFlag2.Visible = false;
            }
            if (Database.loadData.Rows.Count > 2 + 13 * page)
            {
                labelWord3.Visible = true;
                labelMeaning3.Visible = true;
                labelWord3.Text = Database.loadData.Rows[page * 13 + 2]["Word"].ToString();
                labelMeaning3.Text = Database.loadData.Rows[page * 13 + 2]["meaning"].ToString();
                language3 = Database.loadData.Rows[page * 13 + 2]["languages"].ToString();
                Bookmark3.Visible = true;
                if (check[page * 13 + 3] == true)
                    Bookmark3.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark3.IconColor = Color.Gainsboro;
                speaker3.Visible = true;
                engFlag3.Visible = true;
                vieFlag3.Visible = true;
                if (language3 != "English")
                {
                    engFlag3.Image = Properties.Resources.vietnam;
                    vieFlag3.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord3.Visible = false;
                labelMeaning3.Visible = false;
                speaker3.Visible = false;
                Bookmark3.Visible = false;
                engFlag3.Visible = false;
                vieFlag3.Visible = false;
            }
            if (Database.loadData.Rows.Count > 3 + 13 * page)
            {
                labelWord4.Visible = true;
                labelMeaning4.Visible = true;
                labelWord4.Text = Database.loadData.Rows[page * 13 + 3]["Word"].ToString();
                labelMeaning4.Text = Database.loadData.Rows[page * 13 + 3]["meaning"].ToString();
                if (check[page * 13 + 4] == true)
                    language4 = Database.loadData.Rows[page * 13 + 3]["languages"].ToString();
                Bookmark4.Visible = true;
                if (check[page*13+4]==true)
                    Bookmark4.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark4.IconColor = Color.Gainsboro;
                speaker4.Visible = true;
                engFlag4.Visible = true;
                vieFlag4.Visible = true;
                if (language4 != "English")
                {
                    engFlag4.Image = Properties.Resources.vietnam;
                    vieFlag4.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord4.Visible = false;
                labelMeaning4.Visible = false;
                speaker4.Visible = false;
                Bookmark4.Visible = false;
                engFlag4.Visible = false;
                vieFlag4.Visible = false;
            }
            if (Database.loadData.Rows.Count > 4 + 13 * page)
            {
                labelWord5.Visible = true;
                labelMeaning5.Visible = true;
                labelWord5.Text = Database.loadData.Rows[page * 13 + 4]["Word"].ToString();
                labelMeaning5.Text = Database.loadData.Rows[page * 13 + 4]["meaning"].ToString();
                language5 = Database.loadData.Rows[page * 13 + 4]["languages"].ToString();
                Bookmark5.Visible = true;
                if (check[page * 13 + 5] == true)
                    Bookmark5.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark5.IconColor = Color.Gainsboro;
                speaker5.Visible = true;
                engFlag5.Visible = true;
                vieFlag5.Visible = true;
                if (language5 != "English")
                {
                    engFlag5.Image = Properties.Resources.vietnam;
                    vieFlag5.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord5.Visible = false;
                labelMeaning5.Visible = false;
                speaker5.Visible = false;
                Bookmark5.Visible = false;
                engFlag5.Visible = false;
                vieFlag5.Visible = false;
            }
            if (Database.loadData.Rows.Count > 5 + 13 * page)
            {
                labelWord6.Visible = true;
                labelMeaning6.Visible = true;
                labelWord6.Text = Database.loadData.Rows[page * 13 + 5]["Word"].ToString();
                labelMeaning6.Text = Database.loadData.Rows[page * 13 + 5]["meaning"].ToString();
                language6 = Database.loadData.Rows[page * 13 + 5]["languages"].ToString();
                Bookmark6.Visible = true;
                if (check[page * 13 + 6] == true)
                    Bookmark6.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark6.IconColor = Color.Gainsboro;
                speaker6.Visible = true;
                engFlag6.Visible = true;
                vieFlag6.Visible = true;
                if (language6 != "English")
                {
                    engFlag6.Image = Properties.Resources.vietnam;
                    vieFlag6.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord6.Visible = false;
                labelMeaning6.Visible = false;
                speaker6.Visible = false;
                Bookmark6.Visible = false;
                engFlag6.Visible = false;
                vieFlag6.Visible = false;
            }
            if (Database.loadData.Rows.Count > 6 + 13 * page)
            {
                labelWord7.Visible = true;
                labelMeaning7.Visible = true;
                labelWord7.Text = Database.loadData.Rows[page * 13 + 6]["Word"].ToString();
                labelMeaning7.Text = Database.loadData.Rows[page * 13 + 6]["meaning"].ToString();
                language7 = Database.loadData.Rows[page * 13 + 6]["languages"].ToString();
                Bookmark7.Visible = true;
                if (check[page * 13 + 7] == true)
                    Bookmark7.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark7.IconColor = Color.Gainsboro;
                speaker7.Visible = true;
                engFlag7.Visible = true;
                vieFlag7.Visible = true;
                if (language7 != "English")
                {
                    engFlag7.Image = Properties.Resources.vietnam;
                    vieFlag7.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord7.Visible = false;
                labelMeaning7.Visible = false;
                speaker7.Visible = false;
                Bookmark7.Visible = false;
                engFlag7.Visible = false;
                vieFlag7.Visible = false;
            }
            if (Database.loadData.Rows.Count > 7 + 13 * page)
            {
                labelWord8.Visible = true;
                labelMeaning8.Visible = true;
                labelWord8.Text = Database.loadData.Rows[page * 13 + 7]["Word"].ToString();
                labelMeaning8.Text = Database.loadData.Rows[page * 13 + 7]["meaning"].ToString();
                language8 = Database.loadData.Rows[page * 13 + 7]["languages"].ToString();
                Bookmark8.Visible = true;
                if (check[page * 13 + 8] == true)
                    Bookmark8.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark8.IconColor = Color.Gainsboro;
                speaker8.Visible = true;
                engFlag8.Visible = true;
                vieFlag8.Visible = true;
                if (language8 != "English")
                {
                    engFlag8.Image = Properties.Resources.vietnam;
                    vieFlag8.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord8.Visible = false;
                labelMeaning8.Visible = false;
                speaker8.Visible = false;
                Bookmark8.Visible = false;
                engFlag8.Visible = false;
                vieFlag8.Visible = false;
            }
            if (Database.loadData.Rows.Count > 8 + 13 * page)
            {
                labelWord9.Visible = true;
                labelMeaning9.Visible = true;
                labelWord9.Text = Database.loadData.Rows[page * 13 + 8]["Word"].ToString();
                labelMeaning9.Text = Database.loadData.Rows[page * 13 + 8]["meaning"].ToString();
                language9 = Database.loadData.Rows[page * 13 + 8]["languages"].ToString();
                Bookmark9.Visible = true;
                if (check[page * 13 + 9] == true)
                    Bookmark9.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark9.IconColor = Color.Gainsboro;
                speaker9.Visible = true;
                engFlag9.Visible = true;
                vieFlag9.Visible = true;
                if (language9 != "English")
                {
                    engFlag9.Image = Properties.Resources.vietnam;
                    vieFlag9.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord9.Visible = false;
                labelMeaning9.Visible = false;
                speaker9.Visible = false;
                Bookmark9.Visible = false;
                engFlag9.Visible = false;
                vieFlag9.Visible = false;
            }
            if (Database.loadData.Rows.Count > 9 + 13 * page)
            {
                labelWord10.Visible = true;
                labelMeaning10.Visible = true;
                labelWord10.Text = Database.loadData.Rows[page * 13 + 9]["Word"].ToString();
                labelMeaning10.Text = Database.loadData.Rows[page * 13 + 9]["meaning"].ToString();
                language10 = Database.loadData.Rows[page * 13 + 9]["languages"].ToString();
                Bookmark10.Visible = true;
                if (check[page * 13 + 10] == true)
                    Bookmark10.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark10.IconColor = Color.Gainsboro;
                speaker10.Visible = true;
                engFlag10.Visible = true;
                vieFlag10.Visible = true;
                if (language10 != "English")
                {
                    engFlag10.Image = Properties.Resources.vietnam;
                    vieFlag10.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord10.Visible = false;
                labelMeaning10.Visible = false;
                speaker10.Visible = false;
                Bookmark10.Visible = false;
                engFlag10.Visible = false;
                vieFlag10.Visible = false;
            }
            if (Database.loadData.Rows.Count > 10 + 13 * page)
            {
                labelWord11.Visible = true;
                labelMeaning11.Visible = true;
                labelWord11.Text = Database.loadData.Rows[page * 13 + 10]["Word"].ToString();
                labelMeaning11.Text = Database.loadData.Rows[page * 13 + 10]["meaning"].ToString();
                language11 = Database.loadData.Rows[page * 13 + 10]["languages"].ToString();
                Bookmark11.Visible = true;
                if (check[page * 13 + 11] == true)
                    Bookmark11.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark11.IconColor = Color.Gainsboro;
                speaker11.Visible = true;
                engFlag11.Visible = true;
                vieFlag11.Visible = true;
                if (language11 != "English")
                {
                    engFlag11.Image = Properties.Resources.vietnam;
                    vieFlag11.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord11.Visible = false;
                labelMeaning11.Visible = false;
                speaker11.Visible = false;
                Bookmark11.Visible = false;
                engFlag11.Visible = false;
                vieFlag11.Visible = false;
            }
            if (Database.loadData.Rows.Count > 11 + 13 * page)
            {
                labelWord12.Visible = true;
                labelMeaning12.Visible = true;
                labelWord12.Text = Database.loadData.Rows[page * 13 + 11]["Word"].ToString();
                labelMeaning12.Text = Database.loadData.Rows[page * 13 + 11]["meaning"].ToString();
                language12 = Database.loadData.Rows[page * 13 + 11]["languages"].ToString();
                Bookmark12.Visible = true;
                if (check[page * 13 + 12] == true)
                    Bookmark12.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark12.IconColor = Color.Gainsboro;
                speaker12.Visible = true;
                engFlag12.Visible = true;
                vieFlag12.Visible = true;
                if (language12 != "English")
                {
                    engFlag12.Image = Properties.Resources.vietnam;
                    vieFlag12.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord12.Visible = false;
                labelMeaning12.Visible = false;
                speaker12.Visible = false;
                Bookmark12.Visible = false;
                engFlag12.Visible = false;
                vieFlag12.Visible = false;
            }
            if (Database.loadData.Rows.Count > 12 + 13 * page)
            {
                labelWord13.Visible = true;
                labelMeaning13.Visible = true;
                labelWord13.Text = Database.loadData.Rows[page * 13 + 12]["Word"].ToString();
                labelMeaning13.Text = Database.loadData.Rows[page * 13 + 12]["meaning"].ToString();
                language13 = Database.loadData.Rows[page * 13 + 12]["languages"].ToString();
                Bookmark13.Visible = true;
                if (check[page * 13 + 13] == true)
                    Bookmark13.IconColor = Color.FromArgb(238, 26, 74);
                else
                    Bookmark13.IconColor = Color.Gainsboro;
                speaker13.Visible = true;
                engFlag13.Visible = true;
                vieFlag13.Visible = true;
                if (language13 != "English")
                {
                    engFlag13.Image = Properties.Resources.vietnam;
                    vieFlag13.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord13.Visible = false;
                labelMeaning13.Visible = false;
                speaker13.Visible = false;
                Bookmark13.Visible = false;
                engFlag13.Visible = false;
                vieFlag13.Visible = false;
            }
        }
        
        private void loadSearch()
        {
            for (int i = 0; i < 100000; i++)
                check[i] = true;
            loadData();
        }
        public Bookmark()
        {
            InitializeComponent();
            if (Database.acction != "searchBookmark")
            {
                command = "select * from bookmark order by id DESC";
                loadDatabase(command);
                loadData();
            }
            else loadSearch();
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

        private void Reload_Click(object sender, EventArgs e)
        {
            page = 0;
            command = "select * from bookmark order by id DESC";
            loadDatabase(command);
            loadData();
        }

        private void Bookmark1_Click(object sender, EventArgs e)
        {
            if (Bookmark1.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord1.Text + "'" + "AND languages=" + "'" + language1 + "'";
                Database.deleteBookmark(command);
                Bookmark1.IconColor = Color.Gainsboro;
                check[page * 13 + 1] = false;
            }
            else
            {
                Bookmark1.IconColor= Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord1.Text, labelMeaning1.Text, language1, time);
                check[page * 13 + 1] = true;
            }
        }

        private void Bookmark2_Click(object sender, EventArgs e)
        {
            if (Bookmark2.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord2.Text + "'" + "AND languages=" + "'" + language2 + "'";
                Database.deleteBookmark(command);
                Bookmark2.IconColor = Color.Gainsboro;
                check[page * 13 + 2] = false;
            }
            else
            {
                Bookmark2.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord1.Text, labelMeaning2.Text, language2, time);
                check[page * 13 + 2] = true;
            }
        }

        private void Bookmark3_Click(object sender, EventArgs e)
        {
            if (Bookmark3.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord3.Text + "'" + "AND languages=" + "'" + language3 + "'";
                Database.deleteBookmark(command);
                Bookmark3.IconColor = Color.Gainsboro;
                check[page * 13 + 3] = false;
            }
            else
            {
                Bookmark3.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord3.Text, labelMeaning3.Text, language3, time);
                check[page * 13 + 3] = true;
            }
        }

        private void Bookmark4_Click(object sender, EventArgs e)
        {
            if (Bookmark4.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord4.Text + "'" + "AND languages=" + "'" + language4 + "'";
                Database.deleteBookmark(command);
                Bookmark4.IconColor = Color.Gainsboro;
                check[page * 13 + 4] = false;
            }
            else
            {
                Bookmark4.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord4.Text, labelMeaning4.Text, language4, time);
                check[page * 13 + 4] = true;
            }
        }

        private void Bookmark5_Click(object sender, EventArgs e)
        {
            if (Bookmark5.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord5.Text + "'" + "AND languages=" + "'" + language5 + "'";
                Database.deleteBookmark(command);
                Bookmark5.IconColor = Color.Gainsboro;
                check[page * 13 + 5] = false;
            }
            else
            {
                Bookmark5.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord5.Text, labelMeaning5.Text, language5, time);
                check[page * 13 + 5] = true;
            }
        }

        private void Bookmark6_Click(object sender, EventArgs e)
        {
            if (Bookmark6.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord6.Text + "'" + "AND languages=" + "'" + language6 + "'";
                Database.deleteBookmark(command);
                Bookmark6.IconColor = Color.Gainsboro;
                check[page * 13 + 6] = false;
            }
            else
            {
                Bookmark6.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord6.Text, labelMeaning6.Text, language6, time);
                check[page * 13 + 6] = true;
            }
        }

        private void Bookmark7_Click(object sender, EventArgs e)
        {
            if (Bookmark7.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord7.Text + "'" + "AND languages=" + "'" + language7 + "'";
                Database.deleteBookmark(command);
                Bookmark7.IconColor = Color.Gainsboro;
                check[page * 13 + 7] = false;
            }
            else
            {
                Bookmark7.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord7.Text, labelMeaning7.Text, language7, time);
                check[page * 13 + 7] = true;
            }
        }

        private void Bookmark8_Click(object sender, EventArgs e)
        {
            if (Bookmark8.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord8.Text + "'" + "AND languages=" + "'" + language8 + "'";
                Database.deleteBookmark(command);
                Bookmark8.IconColor = Color.Gainsboro;
                check[page * 13 + 8] = false;
            }
            else
            {
                Bookmark8.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord8.Text, labelMeaning8.Text, language8, time);
                check[page * 13 + 8] = true;
            }
        }

        private void Bookmark9_Click(object sender, EventArgs e)
        {
            if (Bookmark9.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord9.Text + "'" + "AND languages=" + "'" + language9 + "'";
                Database.deleteBookmark(command);
                Bookmark9.IconColor = Color.Gainsboro;
                check[page * 13 + 9] = false;
            }
            else
            {
                Bookmark9.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord9.Text, labelMeaning9.Text, language9, time);
                check[page * 13 + 9] = true;
            }
        }

        private void Bookmark10_Click(object sender, EventArgs e)
        {
            if (Bookmark10.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord10.Text + "'" + "AND languages=" + "'" + language10 + "'";
                Database.deleteBookmark(command);
                Bookmark10.IconColor = Color.Gainsboro;
                check[page * 13 + 10] = false;
            }
            else
            {
                Bookmark10.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord10.Text, labelMeaning10.Text, language10, time);
                check[page * 13 + 10] = true;
            }
        }

        private void Bookmark11_Click(object sender, EventArgs e)
        {
            if (Bookmark11.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord11.Text + "'" + "AND languages=" + "'" + language11 + "'";
                Database.deleteBookmark(command);
                Bookmark11.IconColor = Color.Gainsboro;
                check[page * 13 + 11] = false;
            }
            else
            {
                Bookmark11.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord11.Text, labelMeaning11.Text, language11, time);
                check[page * 13 + 11] = true;
            }
        }

        private void Bookmark12_Click(object sender, EventArgs e)
        {
            if (Bookmark12.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord12.Text + "'" + "AND languages=" + "'" + language12 + "'";
                Database.deleteBookmark(command);
                Bookmark12.IconColor = Color.Gainsboro;
                check[page * 13 + 12] = false;
            }
            else
            {
                Bookmark12.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord12.Text, labelMeaning12.Text, language12, time);
                check[page * 13 + 12] = true;
            }
        }

        private void Bookmark13_Click(object sender, EventArgs e)
        {
            if (Bookmark13.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord13.Text + "'" + "AND languages=" + "'" + language13 + "'";
                Database.deleteBookmark(command);
                Bookmark13.IconColor = Color.Gainsboro;
                check[page * 13 + 13] = false;
            }
            else
            {
                Bookmark13.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord13.Text, labelMeaning13.Text, language13, time);
                check[page * 13 + 13] = true;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if ((page + 1) * 13 < Database.loadData.Rows.Count)
            {
                page = page + 1;
                loadData();
            }
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page = page - 1;
                loadData();
            }
        }

        private void buttonDateDesc_Click(object sender, EventArgs e)
        {
            page = 0;
            command = "select * from bookmark order by id DESC";
            loadDatabase(command);
            loadData();
        }

        private void buttonDateAsc_Click(object sender, EventArgs e)
        {
            page = 0;
            command = "select * from bookmark order by id ASC";
            loadDatabase(command);
            loadData();
        }

        private void buttonWordAsc_Click(object sender, EventArgs e)
        {
            page = 0;
            command = "select * from bookmark order by Word ASC";
            loadDatabase(command);
            loadData();
        }

        private void buttonWorDesc_Click(object sender, EventArgs e)
        {
            page = 0;
            command = "select * from bookmark order by Word DESC";
            loadDatabase(command);
            loadData();
        }

        private void iconButtonExcel_Click(object sender, EventArgs e)
        {
            DataView view = new DataView(Database.loadData);
            DataTable selected = view.ToTable(false, "word", "meaning", "savedtime");   
            var folderBrowserDialog1 = new FolderBrowserDialog();
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Excel.ExcelUtlity obj = new Excel.ExcelUtlity();
                string folderName = folderBrowserDialog1.SelectedPath;
                obj.WriteDataTableToExcel(selected, "Bookmark List", folderName +"BookmarkList.xlsx", "BookmarkList");
                MessageBox.Show("File was created");
            }   
        }

        private void labelWord1_MouseHover(object sender, EventArgs e)
        {
            labelWord1.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning1.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord2_MouseHover(object sender, EventArgs e)
        {
            labelWord2.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning2.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord3_MouseHover(object sender, EventArgs e)
        {
            labelWord3.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning3.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord4_MouseHover(object sender, EventArgs e)
        {
            labelWord4.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning4.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord5_MouseHover(object sender, EventArgs e)
        {
            labelWord5.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning5.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord6_MouseHover(object sender, EventArgs e)
        {
            labelWord6.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning6.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord7_MouseHover(object sender, EventArgs e)
        {
            labelWord7.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning7.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord8_MouseHover(object sender, EventArgs e)
        {
            labelWord8.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning8.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord9_MouseHover(object sender, EventArgs e)
        {
            labelWord9.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning9.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord10_MouseHover(object sender, EventArgs e)
        {
            labelWord10.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning10.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord11_MouseHover(object sender, EventArgs e)
        {
            labelWord11.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning11.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord12_MouseHover(object sender, EventArgs e)
        {
            labelWord12.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning12.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord13_MouseHover(object sender, EventArgs e)
        {
            labelWord13.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning13.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelWord1_MouseLeave(object sender, EventArgs e)
        {
            labelWord1.ForeColor = Color.Gainsboro;
            labelMeaning1.ForeColor = Color.Gainsboro;
        }

        private void labelWord2_MouseLeave(object sender, EventArgs e)
        {
            labelWord2.ForeColor = Color.Gainsboro;
            labelMeaning2.ForeColor = Color.Gainsboro;
        }

        private void labelWord3_MouseLeave(object sender, EventArgs e)
        {
            labelWord3.ForeColor = Color.Gainsboro;
            labelMeaning3.ForeColor = Color.Gainsboro;
        }

        private void labelWord4_MouseLeave(object sender, EventArgs e)
        {
            labelWord4.ForeColor = Color.Gainsboro;
            labelMeaning4.ForeColor = Color.Gainsboro;
        }

        private void labelWord5_MouseLeave(object sender, EventArgs e)
        {
            labelWord5.ForeColor = Color.Gainsboro;
            labelMeaning5.ForeColor = Color.Gainsboro;
        }

        private void labelWord6_MouseLeave(object sender, EventArgs e)
        {
            labelWord6.ForeColor = Color.Gainsboro;
            labelMeaning6.ForeColor = Color.Gainsboro;
        }

        private void labelWord7_MouseLeave(object sender, EventArgs e)
        {
            labelWord7.ForeColor = Color.Gainsboro;
            labelMeaning7.ForeColor = Color.Gainsboro;
        }

        private void labelWord8_MouseLeave(object sender, EventArgs e)
        {
            labelWord8.ForeColor = Color.Gainsboro;
            labelMeaning8.ForeColor = Color.Gainsboro;
        }

        private void labelWord9_MouseLeave(object sender, EventArgs e)
        {
            labelWord9.ForeColor = Color.Gainsboro;
            labelMeaning9.ForeColor = Color.Gainsboro;
        }

        private void labelWord10_MouseLeave(object sender, EventArgs e)
        {
            labelWord10.ForeColor = Color.Gainsboro;
            labelMeaning10.ForeColor = Color.Gainsboro;
        }

        private void labelWord11_MouseLeave(object sender, EventArgs e)
        {
            labelWord11.ForeColor = Color.Gainsboro;
            labelMeaning11.ForeColor = Color.Gainsboro;
        }

        private void labelWord12_MouseLeave(object sender, EventArgs e)
        {
            labelWord12.ForeColor = Color.Gainsboro;
            labelMeaning12.ForeColor = Color.Gainsboro;
        }

        private void labelWord13_MouseLeave(object sender, EventArgs e)
        {
            labelWord13.ForeColor = Color.Gainsboro;
            labelMeaning13.ForeColor = Color.Gainsboro;
        }

        private void labelWord1_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord1.Text;
            if (language1 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord2_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord2.Text;
            if (language2 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord3_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord3.Text;
            if (language3 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord4_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord4.Text;
            if (language4 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord5_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord5.Text;
            if (language5 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord6_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord6.Text;
            if (language6 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord7_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord7.Text;
            if (language7 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord8_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord8.Text;
            if (language8 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord9_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord9.Text;
            if (language9 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord10_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord10.Text;
            if (language10 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord11_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord11.Text;
            if (language11 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord12_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord12.Text;
            if (language12 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelWord13_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord13.Text;
            if (language13 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning1_MouseHover(object sender, EventArgs e)
        {
            labelWord1.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning1.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning1_MouseLeave(object sender, EventArgs e)
        {
            labelWord1.ForeColor = Color.Gainsboro;
            labelMeaning1.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning2_MouseHover(object sender, EventArgs e)
        {
            labelWord2.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning2.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning2_MouseLeave(object sender, EventArgs e)
        {
            labelWord2.ForeColor = Color.Gainsboro;
            labelMeaning2.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning3_MouseHover(object sender, EventArgs e)
        {
            labelWord3.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning3.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning3_MouseLeave(object sender, EventArgs e)
        {
            labelWord3.ForeColor = Color.Gainsboro;
            labelMeaning3.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning4_MouseHover(object sender, EventArgs e)
        {
            labelWord4.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning4.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning4_MouseLeave(object sender, EventArgs e)
        {
            labelWord4.ForeColor = Color.Gainsboro;
            labelMeaning4.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning5_MouseHover(object sender, EventArgs e)
        {
            labelWord5.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning5.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning5_MouseLeave(object sender, EventArgs e)
        {
            labelWord5.ForeColor = Color.Gainsboro;
            labelMeaning5.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning6_MouseHover(object sender, EventArgs e)
        {
            labelWord6.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning6.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning6_MouseLeave(object sender, EventArgs e)
        {
            labelWord6.ForeColor = Color.Gainsboro;
            labelMeaning6.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning7_MouseHover(object sender, EventArgs e)
        {
            labelWord7.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning7.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning7_MouseLeave(object sender, EventArgs e)
        {
            labelWord7.ForeColor = Color.Gainsboro;
            labelMeaning7.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning8_MouseHover(object sender, EventArgs e)
        {
            labelWord8.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning8.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning8_MouseLeave(object sender, EventArgs e)
        {
            labelWord8.ForeColor = Color.Gainsboro;
            labelMeaning8.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning9_MouseHover(object sender, EventArgs e)
        {
            labelWord9.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning9.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning9_MouseLeave(object sender, EventArgs e)
        {
            labelWord9.ForeColor = Color.Gainsboro;
            labelMeaning9.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning10_MouseHover(object sender, EventArgs e)
        {
            labelWord10.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning10.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning10_MouseLeave(object sender, EventArgs e)
        {
            labelWord10.ForeColor = Color.Gainsboro;
            labelMeaning10.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning11_MouseHover(object sender, EventArgs e)
        {
            labelWord11.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning11.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning11_MouseLeave(object sender, EventArgs e)
        {
            labelWord11.ForeColor = Color.Gainsboro;
            labelMeaning11.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning12_MouseHover(object sender, EventArgs e)
        {
            labelWord12.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning12.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning12_MouseLeave(object sender, EventArgs e)
        {
            labelWord12.ForeColor = Color.Gainsboro;
            labelMeaning12.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning13_MouseHover(object sender, EventArgs e)
        {
            labelWord13.ForeColor = Color.FromArgb(238, 26, 74);
            labelMeaning13.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void labelMeaning13_MouseLeave(object sender, EventArgs e)
        {
            labelWord13.ForeColor = Color.Gainsboro;
            labelMeaning13.ForeColor = Color.Gainsboro;
        }

        private void labelMeaning1_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord1.Text;
            if (language1 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning2_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord2.Text;
            if (language2 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning3_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord3.Text;
            if (language3 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning4_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord4.Text;
            if (language4 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning5_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord5.Text;
            if (language5 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning6_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord6.Text;
            if (language6 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning7_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord7.Text;
            if (language7 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning8_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord8.Text;
            if (language8 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning9_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord9.Text;
            if (language9 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning10_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord10.Text;
            if (language10 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning11_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord11.Text;
            if (language11 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning12_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord12.Text;
            if (language12 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }

        private void labelMeaning13_Click(object sender, EventArgs e)
        {
            Database.acction = "clickFromBookmark";
            Database.word = labelWord13.Text;
            if (language13 == "English")
                Database.setLanguages = false;
            else Database.setLanguages = true;
            this.Close();
        }
    }
}
     