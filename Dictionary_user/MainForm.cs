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
        private int hintColor = 0;
        //private object[] suggestion = new object[4];
        private string coloumn = "VieMeaning";
        private string hint = "English";
        private string command = "";
        public string date = DateTime.Now.ToString("yyyy.MM.dd");
        public string time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private struct RGBColors // Struct các mã màu 
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(238, 26, 74);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(255, 244, 79);
        }


        #endregion

        #region Menu and Titlebar

        private void displaySearch() // Hiển thị chức năng tìm kiếm
        {
            textboxSearch.Visible = true;
            buttonSearch.Visible = true;
        }
        private void hideSearch() // Ẩn chức năng tìm kiếm
        {
            textboxSearch.Visible = false;
            buttonSearch.Visible = false;
        }
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
        private void setVisibleResult(bool set)
        {
            typedWord.Visible = set;
            bookmarkButton.Visible = set;
            wordMeaning.Visible = set;
            btnPlay.Visible = set;
            btnPlay2.Visible = set;
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
        private void reloadRecentHistory()
        {
            labelHistory4.Text = labelHistory3.Text;
            labelHistory3.Text = labelHistory2.Text;
            labelHistory2.Text = labelHistory1.Text;
            labelHistory1.Text = typedWord.Text;
        }
        private void updateHistoryBookmark()
        {
            if (bookmarkButton.IconColor == RGBColors.color7)
            {
                if (hint == "English")
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Eng-Vie'");
                else
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Vie-Eng'");
            }
            else
            {

                if (hint == "English")
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Eng-Vie'");
                else
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Vie-Eng'");
            }
        }
        private void loadBookmark()
        {
            command = " SELECT meaning from bookmark where word = " + "\"" + textboxSearch.Text.ToString() + "\"" + "and languages= " + "'" + hint + "'";
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
        /*  private void initSuggestion()
          {
              suggestion[0] = labelHint3;
              suggestion[1] = labelHint1;
              suggestion[2] = labelHint2;
              suggestion[3] = labelHint4;
          }*/
        private void loadRecentlyBookmark()
        {
            command = "SELECT Word from bookmark where languages=" + "'" + hint + "'" + " ORDER BY id DESC";
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
        private void loadRecentlyHistory()
        {

            if (hint == "English")
                command = "SELECT Word from historysearch where Translate='Eng-Vie' ORDER BY id DESC";
            else
                command = "SELECT Word from historysearch where Translate='Vie-Eng' ORDER BY id DESC";
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
        private void loadRecently()// Load recently history and recently bookmark
        {
            loadRecentlyHistory();
            loadRecentlyBookmark();
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
        private void loadResult()
        {
            if (textboxSearch.HintText == "Search English")
            {
                command = " SELECT VieMeaning from mytable where English = " + "\"" + textboxSearch.Text.ToString() + "\"";
                Database.load(command);
                typedWord.Text = textboxSearch.Text;
                if (Database.loadData.Rows.Count > 0)
                    wordMeaning.Text = Database.loadData.Rows[0][coloumn].ToString();
                else
                    wordMeaning.Text = "Not Found";
                Database.insertHistory(textboxSearch.Text, wordMeaning.Text, date, "No", "Eng-Vie");
                btnPlay.Visible = true;
                btnPlay2.Visible = false;
            }
            else
            {
                command = " SELECT English from mytable where VieMeaning = " + "\"" + textboxSearch.Text.ToString() + "\"";
                Database.load(command);
                typedWord.Text = textboxSearch.Text;
                if (Database.loadData.Rows.Count > 0)
                    wordMeaning.Text = Database.loadData.Rows[0][coloumn].ToString();
                else
                    wordMeaning.Text = "Not Found";
                Database.insertHistory(textboxSearch.Text, wordMeaning.Text, date, "No", "Vie-Eng");
                btnPlay2.Visible = true;
                btnPlay.Visible = false;
            }
        }
        private void activateSearchButton() // Kích hoạt searchButton
        {
            if (Database.nowForm == 1)
            {
                Database.acction = "Translate";
                setVisibleResult(true);
                loadResult();
                reloadRecentHistory();
                loadBookmark();
                updateHistoryBookmark();
            }
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
        private void activateSwitchButton() // Kích hoạt switchButton 
        {
            if (ktSwitch == true)
            {
                pictureBoxFlagLeft.Image = Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = Properties.Resources.united_kingdom;
                textboxSearch.HintText = "Search VietNamese";
                textboxSearch.Text = "Search VietNamese";
                coloumn = "English";
                hint = "VieMeaning";
            }
            else
            {
                pictureBoxFlagLeft.Image = Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = Properties.Resources.vietnam;
                textboxSearch.HintText = "Search English";
                textboxSearch.Text = "Search English";
                coloumn = "VieMeaning";
                hint = "English";
            }
            resetSuggestion();
            loadRecentlyHistory();
            loadRecentlyBookmark();
        }
        private void closeChildForm(Form childForm)
        {
            childForm.FormClosed += new FormClosedEventHandler(Form_Closed);
            void Form_Closed(object sender, FormClosedEventArgs e)
            {
                if (Database.acction == "clickFromBookmark")
                {
                    activateMenuButton(iconButton1, RGBColors.color1);
                    displaySwitch();
                    ktSwitch = Database.setLanguages;
                    activateSwitchButton();
                    displaySearch();
                    textboxSearch.LineFocusedColor = RGBColors.color1;
                    textboxSearch.LineMouseHoverColor = RGBColors.color1;
                    buttonSearch.IconColor = RGBColors.color1;
                    Database.nowForm = 1;
                    checkBookMark();
                    textboxSearch.Text = Database.word;
                    activateSearchButton();
                    if (bookmarkButton.IconColor == RGBColors.color7)
                    {
                        if (hint == "English")
                            Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Eng-Vie'");
                        else
                            Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Vie-Eng'");
                    }
                    if (bookmarkButton.IconColor == Color.Gainsboro)
                    {

                        if (hint == "English")
                            Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Eng-Vie'");
                        else
                            Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Vie-Eng'");
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


        public MainForm() // Kích hoạt MainForm
        {
            //Initial GUI
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 34);
            panelMenu.Controls.Add(leftBorderBtn);
            activateMenuButton(iconButton1, RGBColors.color1);
            //initSuggestion();
            loadRecently();
            Database.nowForm = 1;
        }

        private void textboxSearch_OnValueChanged(object sender, EventArgs e) // Khi thay đổi giá trị textboxSearch 
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
            command = "Use sql_invoicing; SELECT " + hint + " from mytable where " + hint + " like " + "'" + textboxSearch.Text + "%'";
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

        private void buttonSearch_Click(object sender, EventArgs e) // Khi click vào searchButton
        {
            if (textboxSearch.Text == "")
            {
                MessageBox.Show("Please insert the word that needs to be translated!");
            }
            else
            {
                activateSearchButton();
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

        private void buttonSwitch_Click(object sender, EventArgs e) // Khi click vào switchButton
        {
            if (ktSwitch == false)
                ktSwitch = true;
            else ktSwitch = false;
            setVisibleResult(false);
            loadRecentlyBookmark();
            activateSwitchButton();
        }

        private void iconButton1_Click(object sender, EventArgs e) // Khi click vào translateButton
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
            activateMenuButton(sender, RGBColors.color1);
            displaySwitch();
            activateSwitchButton();
            displaySearch();
            textboxSearch.LineFocusedColor = RGBColors.color1;
            textboxSearch.LineMouseHoverColor = RGBColors.color1;
            buttonSearch.IconColor = RGBColors.color1;
            Database.nowForm = 1;
            checkBookMark();
        }

        private void btnHistory_Click(object sender, EventArgs e) // Khi click vào historyButton
        {
            hideSwitch();
            displaySearch();
            textboxSearch.HintText = "Search history";
            textboxSearch.Text = textboxSearch.HintText;
            textboxSearch.LineFocusedColor = RGBColors.color3;
            textboxSearch.LineMouseHoverColor = RGBColors.color3;
            buttonSearch.IconColor = RGBColors.color3;
            Database.nowForm = 2;
            Database.acction = "showHistoryList";
            activateMenuButton(sender, RGBColors.color3);
            openChildForm(new History());
        }

        private void btn_Bookmark_Click(object sender, EventArgs e) // Khi click vào bookmarkButton
        {
            hideSwitch();
            displaySearch();
            textboxSearch.HintText = "Search bookmark";
            textboxSearch.Text = textboxSearch.HintText;
            textboxSearch.LineFocusedColor = RGBColors.color2;
            textboxSearch.LineMouseHoverColor = RGBColors.color2;
            buttonSearch.IconColor = RGBColors.color2;
            Database.nowForm = 3;
            Database.acction = "showBookmarkList";
            activateMenuButton(sender, RGBColors.color2);
            openChildForm(new Bookmark());
        }

        private void btnSettings_Click(object sender, EventArgs e) // Khi click vào settingsButton
        {
            activateMenuButton(sender, RGBColors.color4);
            openChildForm(new Settings());
            hideSearch();
            hideSwitch();
        }

        private void btnHelp_Click(object sender, EventArgs e) // Khi click vào helpButton
        {
            activateMenuButton(sender, RGBColors.color5);
            openChildForm(new Help());
            hideSearch();
            hideSwitch();
        }

        private void btnFeedback_Click(object sender, EventArgs e) // Khi click vào feedbackButton
        {
            activateMenuButton(sender, RGBColors.color6);
            openChildForm(new Feedback());
            hideSearch();
            hideSwitch();
        }

        #endregion

        #region Suggestion, History, Bookmark

        #region Suggestion

        private void labelHint1_MouseHover(object sender, EventArgs e)
        {
            labelHint1.ForeColor = RGBColors.color7;
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

        #region Search_Result

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

        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            if (ktBookmark == false)
            {
                ktBookmark = true;
                bookmarkButton.IconColor = RGBColors.color7;
                Database.insertBookmark(typedWord.Text, wordMeaning.Text, hint, time);
                if (hint == "English")
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Eng-Vie'");
                else
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Vie-Eng'");
                loadRecentlyBookmark();
            }
            else
            {
                ktBookmark = false;
                bookmarkButton.IconColor = Color.Gainsboro;
                command = "delete from bookmark where word =" + "'" + typedWord.Text + "'" + "AND languages=" + "'" + hint + "'";
                Database.deleteBookmark(command);
                if (hint == "English")
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Eng-Vie'");
                else
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Vie-Eng'");
                loadRecentlyBookmark();
            }
        }




        #endregion Search_Result

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
    }
}

