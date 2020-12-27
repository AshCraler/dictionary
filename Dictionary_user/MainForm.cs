using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using FontAwesome.Sharp;
using System.Speech.Synthesis;
using MySql.Data;
using MySql.Data.MySqlClient;
//////
namespace Dictionary_user
{
    public partial class MainForm : Form
    {

        #region Declaration 


        private IconButton currentBtn; // Button đang được chọn hiện tại
        private Panel leftBorderBtn; // Panel chứa các chức năng chính
        private Form currentChildForm; // Child form đang được mở hiện tại 
        private bool ktSwitch = false; // Kiểm tra chế độ Anh Việt hay Việt Anh
        private bool ktBookmark = false; // Kiểm tra bookmark hay chưa
        private string coloumn = "VieMeaning";
        private string hint = "English";
        private string command = "";
        private int id = 0;
        private string date = DateTime.Now.ToString("yyyy.MM.dd");
        private string time;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private List<string> arr;
        private Random r = new Random();
        private string language;
        private PictureBox pictureLanguage = new PictureBox();
        private struct RGBColors // Struct các mã màu 
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(238, 26, 74);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(65, 179, 247);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(255, 244, 79);
        }


        #endregion

        #region Menu and Titlebar

        private void displaySwitch() // Hiển thị chức năng chuyển ngôn ngữ
        {
            buttonSwitch.Visible = true;
            pictureBoxFlagLeft.Visible = true;
            pictureBoxFlagRight.Visible = true;
        }
        private void hideSwitch() // Ẩn chức năng chuyển ngôn ngữ
        {
            pictureBoxFlagLeft.Visible = false;
            pictureBoxFlagRight.Visible = false;
            buttonSwitch.Visible = false;
        }
        private void activateMenuButton(object senderBtn, Color color) // Kích hoạt menuButton 
        {
            disableMenuButton();
            //Button
            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = color;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            //Left border button
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            iconCurrentChildForm.IconChar = currentBtn.IconChar;
            iconCurrentChildForm.IconColor = color;
            labelTitleChildForm.Text = currentBtn.Text;
        }
        private void disableMenuButton()  // Tắt menuButton 
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void resetSuggestion()
        {
            labelHint1.Text = "";
            labelHint2.Text = "";
            labelHint3.Text = "";
            labelHint4.Text = "";
        }
        private void resetSuggestionColor()
        {
            labelHint1.ForeColor = Color.Gainsboro;
            labelHint2.ForeColor = Color.Gainsboro;
            labelHint3.ForeColor = Color.Gainsboro;
            labelHint4.ForeColor = Color.Gainsboro;
        }
        private void loadRecently()// Load recently history and recently bookmark
        {
            loadRecentlyHistory();
            loadRecentlyBookmark();
        }
        private void activateSwitchButton() // Kích hoạt switchButton 
        {
            if (ktSwitch == true)
            {
                pictureBoxFlagLeft.Image = Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = pictureLanguage.Image;
                textboxSearch.HintText = "Search VietNamese";
                textboxSearch.Text = "Search VietNamese";
                coloumn = language;
                hint = "VieMeaning";
                iconButtonSpeaker1.Visible = false;
                iconButtonSpeaker2.Visible = false;
                iconButtonSpeaker3.Visible = false;
                iconButtonSpeaker4.Visible = false;
                iconButtonSpeaker5.Visible = false;
                iconButtonSpeaker6.Visible = false;
                iconButtonSpeaker7.Visible = false;
                iconButtonSpeaker8.Visible = false;
            }
            else
            {
                pictureBoxFlagLeft.Image = pictureLanguage.Image;
                pictureBoxFlagRight.Image = Properties.Resources.vietnam;
                textboxSearch.HintText = "Search "+language;
                textboxSearch.Text = "Search "+language;
                iconButtonSpeaker1.Visible = true;
                iconButtonSpeaker2.Visible = true;
                iconButtonSpeaker3.Visible = true;
                iconButtonSpeaker4.Visible = true;
                iconButtonSpeaker5.Visible = true;
                iconButtonSpeaker6.Visible = true;
                iconButtonSpeaker7.Visible = true;
                iconButtonSpeaker8.Visible = true;
                coloumn = "VieMeaning";
                hint = language;
            }
            resetSuggestion();
            loadRecentlyHistory();
            loadRecentlyBookmark();
        }
        
        public MainForm() // Kích hoạt MainForm
        {
            //Initial GUI
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 34);
            panelMenu.Controls.Add(leftBorderBtn);
            activateMenuButton(iconButton1, RGBColors.color1);
            bunifuDropdownTranslate.selectedIndex = 0;      
            Database.nowForm = 1;
            Database.acction = "Translate";
            language = "English";
            pictureLanguage.Image = Properties.Resources.united_kingdom;
            bunifuDropdownTranslate.selectedIndex = 0;
            Database.selectedIndex = 0;
            loadRecently();
            loadVolcabulary();
            Database.flag = new Dictionary<string, PictureBox>();
            PictureBox English = new PictureBox();
            English.Image = Properties.Resources.united_kingdom;
            Database.flag.Add("English", English);
            PictureBox French = new PictureBox();
            French.Image = Properties.Resources.france;
            Database.flag.Add("French", French);
            PictureBox German = new PictureBox();
            German.Image = Properties.Resources.germany;
            Database.flag.Add("German", German);
            PictureBox VieMeaning = new PictureBox();
            VieMeaning.Image = Properties.Resources.vietnam;
            Database.flag.Add("VieMeaning", VieMeaning);
        }
       
        private void buttonSwitch_Click(object sender, EventArgs e) // Khi click vào switchButton
        {
            if (ktSwitch == false)
                ktSwitch = true;
            else ktSwitch = false;
            setSearchResult_visible(false);
            loadRecentlyBookmark();
            activateSwitchButton();
            loadVolcabulary();
        }


        #endregion

        #region Suggestion, History, Bookmark

        #region Suggestion

        private void labelHint1_MouseHover(object sender, EventArgs e)
        {
            labelHint1.ForeColor = RGBColors.color7;
            labelHint1.Cursor = Cursors.Hand;
        }

        private void labelHint1_MouseLeave(object sender, EventArgs e)
        {
            labelHint1.ForeColor = Color.Gainsboro;
        }

        private void labelHint1_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHint1.Text;
            activateSearchButton();
        }

        private void labelHint2_MouseHover(object sender, EventArgs e)
        {
            labelHint2.ForeColor = RGBColors.color7;
            labelHint2.Cursor = Cursors.Hand;
        }

        private void labelHint2_MouseLeave(object sender, EventArgs e)
        {
            labelHint2.ForeColor = Color.Gainsboro;
        }

        private void labelHint2_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHint2.Text;
            activateSearchButton();
        }

        private void labelHint3_MouseHover(object sender, EventArgs e)
        {
            labelHint4.ForeColor = RGBColors.color7;
            labelHint4.Cursor = Cursors.Hand;
        }

        private void labelHint3_MouseLeave(object sender, EventArgs e)
        {
            labelHint4.ForeColor = Color.Gainsboro;
        }

        private void labelHint3_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHint4.Text;
            activateSearchButton();
        }

        private void labelHint4_MouseHover(object sender, EventArgs e)
        {
            labelHint3.ForeColor = RGBColors.color7;
            labelHint3.Cursor = Cursors.Hand;
        }

        private void labelHint4_MouseLeave(object sender, EventArgs e)
        {
            labelHint3.ForeColor = Color.Gainsboro;
        }

        private void labelHint4_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHint3.Text;
            activateSearchButton();
        }


        #endregion Suggestion

        #region History

        private void labelHistory1_MouseHover(object sender, EventArgs e)
        {
            labelHistory1.ForeColor = RGBColors.color3;
            labelHistory1.Cursor = Cursors.Hand;
        }

        private void labelHistory1_MouseLeave(object sender, EventArgs e)
        {
            labelHistory1.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelHistory1_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHistory1.Text;
            activateSearchButton();
        }

        private void labelHistory2_MouseHover(object sender, EventArgs e)
        {
            labelHistory2.ForeColor = RGBColors.color3;
            labelHistory2.Cursor = Cursors.Hand;
        }

        private void labelHistory2_MouseLeave(object sender, EventArgs e)
        {
            labelHistory2.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelHistory2_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHistory2.Text;
            activateSearchButton();
        }

        private void labelHistory3_MouseHover(object sender, EventArgs e)
        {
            labelHistory3.ForeColor = RGBColors.color3;
            labelHistory3.Cursor = Cursors.Hand;
        }

        private void labelHistory3_MouseLeave(object sender, EventArgs e)
        {
            labelHistory3.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelHistory3_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHistory3.Text;
            activateSearchButton();
        }

        private void labelHistory4_MouseHover(object sender, EventArgs e)
        {
            labelHistory4.ForeColor = RGBColors.color3;
            labelHistory4.Cursor = Cursors.Hand;
        }

        private void labelHistory4_MouseLeave(object sender, EventArgs e)
        {
            labelHistory4.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelHistory4_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHistory4.Text;
            activateSearchButton();
        }


        #endregion History

        #region Bookmark

        private void labelBookmark1_MouseHover(object sender, EventArgs e)
        {
            labelBookmark1.ForeColor = RGBColors.color2;
            labelBookmark1.Cursor = Cursors.Hand;
        }

        private void labelBookmark1_MouseLeave(object sender, EventArgs e)
        {
            labelBookmark1.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelBookmark1_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelBookmark1.Text;
            activateSearchButton();
        }

        private void labelBookmark2_MouseHover(object sender, EventArgs e)
        {
            labelBookmark2.ForeColor = RGBColors.color2;
            labelBookmark2.Cursor = Cursors.Hand;
        
        }

        private void labelBookmark2_MouseLeave(object sender, EventArgs e)
        {
            labelBookmark2.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelBookmark2_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelBookmark2.Text;
            activateSearchButton();
        }

        private void labelBookmark3_MouseHover(object sender, EventArgs e)
        {
            labelBookmark3.ForeColor = RGBColors.color2;
            labelBookmark3.Cursor = Cursors.Hand;
        }
    
        private void labelBookmark3_MouseLeave(object sender, EventArgs e)
        {
            labelBookmark3.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelBookmark3_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelBookmark3.Text;
            activateSearchButton();
        }

        private void labelBookmark4_MouseHover(object sender, EventArgs e)
        {
            labelBookmark4.ForeColor = RGBColors.color2;
            labelBookmark4.Cursor = Cursors.Hand;
        }

        private void labelBookmark4_MouseLeave(object sender, EventArgs e)
        {
            labelBookmark4.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelBookmark4_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelBookmark4.Text;
            activateSearchButton();
        }


        #endregion Bookmark

        #endregion Suggestion, History, Bookmark

        #region Sound

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (textboxSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ cần tra vào chỗ trống!\nPlease insert the word that needs to be translated!");
            }
            else
            {
                // Initialize a new instance of the SpeechSynthesizer.  
                SpeechSynthesizer synth = new SpeechSynthesizer();

                // Configure the audio output.   
                synth.SetOutputToDefaultAudioDevice();

                // Speak a string.  
                synth.Speak(typedWord.Text);
            }
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            if (textboxSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ cần tra vào chỗ trống!\nPlease insert the word that needs to be translated!");
            }
            else
            {
                // Initialize a new instance of the SpeechSynthesizer.  
                SpeechSynthesizer synth = new SpeechSynthesizer();

                // Configure the audio output.   
                synth.SetOutputToDefaultAudioDevice();

                // Speak a string.  
                synth.Speak(wordMeaning.Text);
            }
        }

        private void iconButtonSpeaker1_Click(object sender, EventArgs e)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(labelWord1.Text);
        }

        private void iconButtonSpeaker2_Click(object sender, EventArgs e)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(labelWord2.Text);
        }

        private void iconButtonSpeaker3_Click(object sender, EventArgs e)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(labelWord3.Text);
        }

        private void iconButtonSpeaker4_Click(object sender, EventArgs e)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(labelWord4.Text);
        }

        private void iconButtonSpeaker5_Click(object sender, EventArgs e)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(labelWord5.Text);
        }

        private void iconButtonSpeaker6_Click(object sender, EventArgs e)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(labelWord6.Text);
        }

        private void iconButtonSpeaker7_Click(object sender, EventArgs e)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(labelWord7.Text);
        }

        private void iconButtonSpeaker8_Click(object sender, EventArgs e)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(labelWord8.Text);
        }
        #endregion 

        #region Keyboard

        private int hintColor = 0;

        private void textboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (hintColor == 0)
                hintColor = 4 * 1000;
            if (e.KeyCode == Keys.Down)
            {
                hintColor++;
                resetSuggestionColor();
                int hintColorAbs = Math.Abs(hintColor % 4);
                if (hintColorAbs == 1)
                    labelHint1.ForeColor = RGBColors.color7;
                if (hintColorAbs == 2)
                    labelHint2.ForeColor = RGBColors.color7;
                if (hintColorAbs == 3)
                    labelHint4.ForeColor = RGBColors.color7;
                if (hintColorAbs == 0)
                    labelHint3.ForeColor = RGBColors.color7;
            }
            if (e.KeyCode == Keys.Up)
            {
                hintColor--;
                resetSuggestionColor();
                int hintColorAbs = Math.Abs(hintColor % 4);
                if (hintColorAbs == 1)
                    labelHint1.ForeColor = RGBColors.color7;
                if (hintColorAbs == 2)
                    labelHint2.ForeColor = RGBColors.color7;
                if (hintColorAbs == 3)
                    labelHint4.ForeColor = RGBColors.color7;
                if (hintColorAbs == 0)
                    labelHint3.ForeColor = RGBColors.color7;
            }
        }

        private void textboxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                if (labelHint1.ForeColor == RGBColors.color7)
                    textboxSearch.Text = labelHint1.Text;
                if (labelHint2.ForeColor == RGBColors.color7)
                    textboxSearch.Text = labelHint2.Text;
                if (labelHint4.ForeColor == RGBColors.color7)
                    textboxSearch.Text = labelHint4.Text;
                if (labelHint3.ForeColor == RGBColors.color7)
                    textboxSearch.Text = labelHint3.Text;
                if (textboxSearch.Text != "")
                    activateSearchButton();
                if (textboxSearch.Text == "")
                    MessageBox.Show("Please insert the word that needs to be translated!");
            }
        }

        private void btnHistory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (e.Modifiers == Keys.Shift)
                    this.ProcessTabKey(false);
                else
                    this.ProcessTabKey(true);
            }
        }

        #endregion

        #region Combobox
        private void bunifuDropdownTranslate_onItemSelected(object sender, EventArgs e)
        {
            if (Database.nowForm == 1)
            {
                if (bunifuDropdownTranslate.selectedIndex == 0)
                {
                    Database.selectedIndex = 0;
                    language = "English";
                    pictureLanguage.Image = Properties.Resources.united_kingdom;
                }
                if (bunifuDropdownTranslate.selectedIndex == 1)
                {
                    Database.selectedIndex = 1;
                    language = "French";
                    pictureLanguage.Image = Properties.Resources.france;
                }
                if (bunifuDropdownTranslate.selectedIndex == 2)
                {
                    Database.selectedIndex = 2;
                    language = "German";
                    pictureLanguage.Image = Properties.Resources.germany;
                }
                if (textboxSearch.HintText == "Search VietNamese")
                {
                    pictureBoxFlagRight.Image = pictureLanguage.Image;
                    hint = "VieMeaning";
                    coloumn = language;
                }
                else
                {
                    hint = language;
                    coloumn = "VieMeaning";
                    pictureBoxFlagLeft.Image = pictureLanguage.Image;
                    textboxSearch.HintText = "Search " + language;
                    textboxSearch.Text = "";
                }
                activateSwitchButton();
                loadVolcabulary();
            }
            if (Database.nowForm == 10)
            {
                if (bunifuDropdownTranslate.selectedIndex == 0)
                {
                    Database.BookandMore = 0;
                    openChildForm(new Idiom());
                }
                if (bunifuDropdownTranslate.selectedIndex == 1)
                {
                    Database.BookandMore = 1;
                    openChildForm(new Idiom());
                }
                if (bunifuDropdownTranslate.selectedIndex == 2)
                {
                    Database.BookandMore = 2;
                    openChildForm(new Idiom());
                }
            }
        }

        #endregion

        #region Volcabulary
        private void Reload_Click(object sender, EventArgs e)
        {
            loadVolcabulary();
        }

        private void labelWord1_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelWord1.Text;
            activateSearchButton();
        }

        private void labelWord2_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelWord2.Text;
            activateSearchButton();
        }

        private void labelWord3_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelWord3.Text;
            activateSearchButton();
        }

        private void labelWord4_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelWord4.Text;
            activateSearchButton();
        }

        private void labelWord5_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelWord5.Text;
            activateSearchButton();
        }

        private void labelWord6_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelWord6.Text;
            activateSearchButton();
        }

        private void labelWord7_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelWord7.Text;
            activateSearchButton();
        }

        private void labelWord8_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelWord8.Text;
            activateSearchButton();
        }

        private void labelWord1_MouseHover(object sender, EventArgs e)
        {
            labelWord1.ForeColor = RGBColors.color7;
            labelWord1.Cursor = Cursors.Hand;
        }

        private void labelWord1_MouseLeave(object sender, EventArgs e)
        {
            labelWord1.ForeColor = Color.Gainsboro;
        }

        private void labelWord2_MouseHover(object sender, EventArgs e)
        {
            labelWord2.ForeColor = RGBColors.color7;
            labelWord2.Cursor = Cursors.Hand;
        }

        private void labelWord2_MouseLeave(object sender, EventArgs e)
        {
            labelWord2.ForeColor = Color.Gainsboro;
        }

        private void labelWord3_MouseHover(object sender, EventArgs e)
        {
            labelWord3.ForeColor = RGBColors.color7;
            labelWord3.Cursor = Cursors.Hand;
        }

        private void labelWord3_MouseLeave(object sender, EventArgs e)
        {
            labelWord3.ForeColor = Color.Gainsboro;
        }

        private void labelWord4_MouseHover(object sender, EventArgs e)
        {
            labelWord4.ForeColor = RGBColors.color7;
            labelWord4.Cursor = Cursors.Hand;
        }

        private void labelWord4_MouseLeave(object sender, EventArgs e)
        {
            labelWord4.ForeColor = Color.Gainsboro;
        }

        private void labelWord5_MouseHover(object sender, EventArgs e)
        {
            labelWord5.ForeColor = RGBColors.color7;
            labelWord5.Cursor = Cursors.Hand;
        }

        private void labelWord5_MouseLeave(object sender, EventArgs e)
        {
            labelWord5.ForeColor = Color.Gainsboro;
        }

        private void labelWord6_MouseHover(object sender, EventArgs e)
        {
            labelWord6.ForeColor = RGBColors.color7;
            labelWord6.Cursor = Cursors.Hand;
        }

        private void labelWord6_MouseLeave(object sender, EventArgs e)
        {
            labelWord6.ForeColor = Color.Gainsboro;
        }

        private void labelWord7_MouseHover(object sender, EventArgs e)
        {
            labelWord7.ForeColor = RGBColors.color7;
            labelWord7.Cursor = Cursors.Hand;
        }

        private void labelWord7_MouseLeave(object sender, EventArgs e)
        {
            labelWord7.ForeColor = Color.Gainsboro;
        }

        private void labelWord8_MouseHover(object sender, EventArgs e)
        {
            labelWord8.ForeColor = RGBColors.color7;
            labelWord8.Cursor = Cursors.Hand;
        }

        private void labelWord8_MouseLeave(object sender, EventArgs e)
        {
            labelWord8.ForeColor = Color.Gainsboro;
        }

        private void random()
        {
            arr = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                id = r.Next(1, 2440);
                command = "select " + hint + " from "+language+"data where id=" + "'" + id.ToString() + "'";
                Database.load(command);
                arr.Add(Database.loadData.Rows[0][hint].ToString());
            }
        }
        
        private void loadVolcabulary()
        {
            random();
            labelWord1.Text = arr[0];
            labelWord2.Text = arr[1];
            labelWord3.Text = arr[2];
            labelWord4.Text = arr[3];
            labelWord5.Text = arr[4];
            labelWord6.Text = arr[5];
            labelWord7.Text = arr[6];
            labelWord8.Text = arr[7];
        }
        
        #endregion

        //Cleaning code, create new regions

        #region Search

        private void displaySearchbar() // Hiển thị chức năng tìm kiếm
        {
            textboxSearch.Visible = true;
            buttonSearch.Visible = true;
        }

        private void hideSearchbar() // Ẩn chức năng tìm kiếm
        {
            textboxSearch.Visible = false;
            buttonSearch.Visible = false;
        }

        private void setSearchResult_visible(bool set)
        {
            typedWord.Visible = set;
            bookmarkButton.Visible = set;
            wordMeaning.Visible = set;
            btnPlay.Visible = set;
            btnPlay2.Visible = set;
        }

        private void loadSearchResult()
        {
            if (textboxSearch.HintText != "Search VietNamese")
            {
                command = " SELECT VieMeaning from "+language+"data where "+language+" = " + "\"" + textboxSearch.Text.ToString() + "\"";
                Database.load(command);
                typedWord.Text = textboxSearch.Text;
                if (Database.loadData.Rows.Count > 0)
                    wordMeaning.Text = Database.loadData.Rows[0][coloumn].ToString();
                else
                    wordMeaning.Text = "Not Found";
                Database.insertHistory(textboxSearch.Text, wordMeaning.Text, date, "No", language+"-VietNamese");
                btnPlay.Visible = true;
                btnPlay2.Visible = false;
            }
            else
            {
                command = " SELECT "+language+" from "+language+"data where VieMeaning = " + "\"" + textboxSearch.Text.ToString() + "\"";
                Database.load(command);
                typedWord.Text = textboxSearch.Text;
                if (Database.loadData.Rows.Count > 0)
                    wordMeaning.Text = Database.loadData.Rows[0][coloumn].ToString();
                else
                    wordMeaning.Text = "Not Found";
                Database.insertHistory(textboxSearch.Text, wordMeaning.Text, date, "No", "VietNamese-"+language);
                btnPlay2.Visible = true;
                btnPlay.Visible = false;
            }
        }

        private void activateSearchButton() // Kích hoạt searchButton
        {
            textboxSearch.Focus();
            if (Database.nowForm == 1)
            {
                Database.acction = "Translate";
                setSearchResult_visible(true);
                loadSearchResult();
                reloadRecentHistory();
                loadBookmark();
                updateBookmarkHistory();
            }// Translate
            if (Database.nowForm == 2)
            {
                Database.acction = "searchHistory";
                Database.textboxSearchText = textboxSearch.Text;
                openChildForm(new History());
            }// Search History 
            if (Database.nowForm == 3)
            {
                Database.acction = "searchBookmark";
                Database.textboxSearchText = textboxSearch.Text;
                openChildForm(new Bookmark());
            } // Search Bookmark
        }

        private void buttonSearch_Click(object sender, EventArgs e) // Khi click vào searchButton
        {
            if (textboxSearch.Text == "")
            {
                MessageBox.Show("Please insert the word that needs to be translated !");
            }
            else
            {
                activateSearchButton();
            }
        }

        private void textboxSearch_OnValueChanged(object sender, EventArgs e) // Khi thay đổi giá trị textboxSearch 
        {
            if (Database.nowForm == 10)
            {
                Database.textboxSearchText = textboxSearch.Text;
            }
            else
            {
                resetSuggestionColor();
                hintColor = 0;
                if (textboxSearch.Text != string.Empty)
                {
                    textboxSearch.LineIdleColor = RGBColors.color1;
                }
                if (textboxSearch.Text == string.Empty)
                {
                    textboxSearch.LineIdleColor = textboxSearch.HintForeColor;
                }
                command = "Use sql_invoicing; SELECT " + hint + " from " +language+"data where " + hint + " like " + "\"" + textboxSearch.Text + "%\"";
                Database.load(command);
                int num = Database.loadData.Rows.Count;
                if (num > 0)
                    labelHint1.Text = Database.loadData.Rows[0][hint].ToString();
                else
                {
                    labelHint1.Text = "";
                    labelHint2.Text = "";
                    labelHint4.Text = "";
                    labelHint3.Text = "";
                }
                if (num > 1)
                    labelHint2.Text = Database.loadData.Rows[1][hint].ToString();
                else
                {
                    labelHint2.Text = "";
                    labelHint4.Text = "";
                    labelHint3.Text = "";
                }
                if (num > 2)
                    labelHint4.Text = Database.loadData.Rows[2][hint].ToString();
                else
                {
                    labelHint4.Text = "";
                    labelHint3.Text = "";
                }
                if (num > 3)
                    labelHint3.Text = Database.loadData.Rows[3][hint].ToString();
                else
                    labelHint3.Text = "";
            }
        }

        #endregion

        #region History

        private void reloadRecentHistory()
        {
            labelHistory4.Text = labelHistory3.Text;
            labelHistory3.Text = labelHistory2.Text;
            labelHistory2.Text = labelHistory1.Text;
            labelHistory1.Text = typedWord.Text;
        }

        private void updateBookmarkHistory()
        {
            if (bookmarkButton.IconColor == RGBColors.color7)
            {
                if (hint != "VieMeaning")
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate= "+"'"+language+"-VietNamese"+"'");
                else
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate= "+"'"+"VietNamese-"+language+"'");
            }
            else
            {

                if (hint != "VieMeaning")
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate= " + "'" + language + "-VietNamese" + "'");
                else
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate= " + "'" + "VietNamese-" + language + "'");
            }
        }

        private void loadRecentlyHistory()
        {

            if (hint != "VieMeaning")
                command = "SELECT Word from historysearch where Translate= " + "'" +language+ "-VietNamese"  + "'"+" ORDER BY id DESC";
            else
                command = "SELECT Word from historysearch where Translate= " + "'" + "VietNamese-" + language + "'" +"ORDER BY id DESC";
            Database.load(command);
            if (Database.loadData.Rows.Count > 0)
                labelHistory1.Text = Database.loadData.Rows[0]["Word"].ToString();
            else
            {
                labelHistory1.Text = "";
                labelHistory2.Text = "";
                labelHistory3.Text = "";
                labelHistory4.Text = "";
            }
            if (Database.loadData.Rows.Count > 1)
                labelHistory2.Text = Database.loadData.Rows[1]["Word"].ToString();
            else
            {
                labelHistory2.Text = "";
                labelHistory3.Text = "";
                labelHistory4.Text = "";
            }
            if (Database.loadData.Rows.Count > 2)
                labelHistory3.Text = Database.loadData.Rows[2]["Word"].ToString();
            else
            {
                labelHistory3.Text = "";
                labelHistory4.Text = "";
            }
            if (Database.loadData.Rows.Count > 3)
                labelHistory4.Text = Database.loadData.Rows[3]["Word"].ToString();
            else
                labelHistory4.Text = "";
        }

        #endregion

        #region Bookmark

        private void loadBookmark()
        {
            command = " SELECT meaning from bookmark where word = " + "\"" + textboxSearch.Text.ToString() + "\"" + "and languages= " + "'" + hint+"-"+coloumn + "'";
            Database.load(command);
            if (Database.loadData.Rows.Count > 0)
            {
                ktBookmark = true;
                bookmarkButton.IconColor = RGBColors.color7;
            }
            else
            {
                ktBookmark = false;
                bookmarkButton.IconColor = Color.Gainsboro;
            }
        }

        private void loadRecentlyBookmark()
        {
            command = "SELECT Word from bookmark where languages=" + "'" + hint+"-"+coloumn + "'" + " ORDER BY id DESC";
            Database.load(command);
            if (Database.loadData.Rows.Count > 0)
                labelBookmark1.Text = Database.loadData.Rows[0]["Word"].ToString();
            else
            {
                labelBookmark1.Text = "";
                labelBookmark2.Text = "";
                labelBookmark3.Text = "";
                labelBookmark4.Text = "";
            }
            if (Database.loadData.Rows.Count > 1)
                labelBookmark2.Text = Database.loadData.Rows[1]["Word"].ToString();
            else
            {
                labelBookmark2.Text = "";
                labelBookmark3.Text = "";
                labelBookmark4.Text = "";
            }
            if (Database.loadData.Rows.Count > 2)
                labelBookmark3.Text = Database.loadData.Rows[2]["Word"].ToString();
            else
            {
                labelBookmark3.Text = "";
                labelBookmark4.Text = "";
            }
            if (Database.loadData.Rows.Count > 3)
                labelBookmark4.Text = Database.loadData.Rows[3]["Word"].ToString();
            else
                labelBookmark4.Text = "";
        }

        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (ktBookmark == false)
            {
                ktBookmark = true;
                bookmarkButton.IconColor = RGBColors.color7;
                Database.insertBookmark(typedWord.Text, wordMeaning.Text, hint+"-"+coloumn, time);
                if (hint != "VieMeaning")
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "\"" + typedWord.Text + "\"" + "AND Translate= "+"'"+language+"-VietNamese"+"'");
                else
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "\"" + typedWord.Text + "\"" + "AND Translate= "+"'"+"VietNamese-"+language+"'");
                loadRecentlyBookmark();
            }
            else
            {
                ktBookmark = false;
                bookmarkButton.IconColor = Color.Gainsboro;
                command = "delete from bookmark where word =" + "\"" + typedWord.Text + "\"" + "AND languages=" + "'" + hint + "'";
                Database.deleteBookmark(command);
                if (hint != "VieMeaning")
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate= " + "'" + language+"-VietNamese" + "'");
                else
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate= " + "'" + "VietNamese-" + language + "'");
                loadRecentlyBookmark();
            }
        }

        private void checkBookMark() // Check and Set color to iconButtonBookmark
        {
            if (labelBookmark1.Text != typedWord.Text)
            {
                bookmarkButton.IconColor = Color.Gainsboro;
                ktBookmark = false;
            }
            else
            {
                bookmarkButton.IconColor = RGBColors.color7;
                ktBookmark = true;
            }
        }
        
        #endregion

        #region Open other form

        private void closeChildForm(Form childForm)
        {
            childForm.FormClosed += new FormClosedEventHandler(Form_Closed);
            void Form_Closed(object sender, FormClosedEventArgs e)
            {
                if (Database.acction == "clickFromBookmark")
                {
                    Database.nowForm = 1;
                    activateMenuButton(iconButton1, RGBColors.color1);
                    displaySwitch();
                    bunifuDropdownTranslate.Visible = true;
                    ktSwitch = Database.setLanguages;
                    Database.setIndex();
                    bunifuDropdownTranslate.selectedIndex = Database.selectedIndex;
                    activateSwitchButton();
                    displaySearchbar();
                    textboxSearch.LineFocusedColor = RGBColors.color1;
                    textboxSearch.LineMouseHoverColor = RGBColors.color1;
                    buttonSearch.IconColor = RGBColors.color1;
                    textboxSearch.Text = Database.word;
                    activateSearchButton();
                    checkBookMark();
                    if (bookmarkButton.IconColor == RGBColors.color7)
                    {
                        if (hint != "VieMeaning")
                            Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate= "+"'" + language+"-VietNamese" + "'");
                        else
                            Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate= " + "'" + "VietNamese-"+language + "'");
                    }
                    if (bookmarkButton.IconColor == Color.Gainsboro)
                    {

                        if (hint != "VieMeaning")
                            Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate= " + "'" + language + "-VietNamese" + "'");
                        else
                            Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate= " + "'" + "VietNamese-" + language+"'");
                    }
                }
            }
        }

        private void openChildForm(Form childForm) // Mở childForm mới
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            closeChildForm(childForm);
        }

        private void iconButton1_Click(object sender, EventArgs e) // Khi click vào translateButton
        {
            Database.nowForm = 1;
            Database.acction="Translate";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
            activateMenuButton(sender, RGBColors.color1);
            displaySwitch();
            displaySearchbar();
            textboxSearch.LineFocusedColor = RGBColors.color1;
            textboxSearch.LineMouseHoverColor = RGBColors.color1;
            buttonSearch.IconColor = RGBColors.color1;
            bunifuDropdownTranslate.Visible = true;
            bunifuDropdownTranslate.Clear();
            bunifuDropdownTranslate.AddItem("English");
            bunifuDropdownTranslate.AddItem("French");
            bunifuDropdownTranslate.AddItem("German");
            bunifuDropdownTranslate.selectedIndex = Database.selectedIndex;
            activateSwitchButton();
            checkBookMark();
        }

        private void btnHistory_Click(object sender, EventArgs e) // Khi click vào historyButton
        {
            hideSwitch();
            displaySearchbar();
            textboxSearch.HintText = "Search history";
            textboxSearch.Text = textboxSearch.HintText;
            textboxSearch.LineFocusedColor = RGBColors.color3;
            textboxSearch.LineMouseHoverColor = RGBColors.color3;
            buttonSearch.IconColor = RGBColors.color3;
            Database.nowForm = 2;
            Database.acction = "showHistoryList";
            activateMenuButton(sender, RGBColors.color3);
            bunifuDropdownTranslate.Visible = false;
            openChildForm(new History());
        }

        private void btn_Bookmark_Click(object sender, EventArgs e) // Khi click vào bookmarkButton
        {
            hideSwitch();
            displaySearchbar();
            textboxSearch.HintText = "Search bookmark";
            textboxSearch.Text = textboxSearch.HintText;
            textboxSearch.LineFocusedColor = RGBColors.color2;
            textboxSearch.LineMouseHoverColor = RGBColors.color2;
            buttonSearch.IconColor = RGBColors.color2;
            Database.nowForm = 3;
            Database.acction = "showBookmarkList";
            activateMenuButton(sender, RGBColors.color2);
            bunifuDropdownTranslate.Visible = false;
            openChildForm(new Bookmark());
        }

        private void btnSettings_Click(object sender, EventArgs e) // Khi click vào settingsButton
        {
            Database.acction = "Settings";
            activateMenuButton(sender, RGBColors.color4);
            openChildForm(new Settings());
            hideSearchbar();
            hideSwitch();
            bunifuDropdownTranslate.Visible = false;
        }

        private void iconIdiom_Click(object sender, EventArgs e)
        {
            Database.nowForm = 10;
            Database.acction = "showIdiomList";
            bunifuDropdownTranslate.Visible = true;
            activateMenuButton(sender, Color.FromArgb(242, 98, 121));
            openChildForm(new Idiom());
            hideSwitch();
            displaySearchbar();
            hideSearchbar();
            bunifuDropdownTranslate.Clear();
            bunifuDropdownTranslate.AddItem("Books");
            bunifuDropdownTranslate.AddItem("Idioms");
            bunifuDropdownTranslate.AddItem("Luminaries");
            bunifuDropdownTranslate.selectedIndex = 0;
           
        } // Book and more

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Database.acction = "Info";
            Color.FromArgb(48, 129, 238);
            hideSwitch();
            displaySearchbar();
            hideSearchbar();
            activateMenuButton(sender, Color.FromArgb(48, 129, 238));
            openChildForm(new About());
            bunifuDropdownTranslate.Visible = false;
        } // About us

        #endregion
 
    }
}


