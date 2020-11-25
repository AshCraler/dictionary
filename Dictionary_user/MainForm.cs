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
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
//////
namespace Dictionary_user
{
    public partial class MainForm : Form
    {

        #region Declaration 

        public DictionaryManager myDictionary;
        private IconButton currentBtn; // Button đang được chọn hiện tại
        private Panel leftBorderBtn; // Panel chứa các chức năng chính
        private Form currentChildForm; // Child form đang được mở hiện tại 
        private bool ktSwitch = false; // Kiểm tra chế độ Anh Việt hay Việt Anh
        private bool ktBookmark = false; // Kiểm tra bookmark hay chưa
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
        private void activateSearchButton() // Kích hoạt searchButton
        {
            typedWord.Visible = true;
            typedWord.Text = textboxSearch.Text;
            labelResult.Visible = true;
            btnPlay.Visible = true;
            bookmarkButton.Visible = true;
            wordMeaning.Visible = true;
            string command= " SELECT VieMeaning from mytable where English = " + "\"" + textboxSearch.Text.ToString() + "\"";
            Database.load(command);
            if (Database.loadData.Tables[0].Rows.Count > 0)
                wordMeaning.Text = Database.loadData.Tables[0].Rows[0]["VieMeaning"].ToString();
            else
                wordMeaning.Text = "This word meaning doesn't have in Database";
            string date = DateTime.Now.ToString("yyyy.MM.dd");
            Database.insertHistory(textboxSearch.Text,wordMeaning.Text,date,"NO");
        }
        private void activateSwitchButton() // Kích hoạt switchButton 
        {
            if (ktSwitch == true)
            {
                pictureBoxFlagLeft.Image = Dictionary_user.Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = Dictionary_user.Properties.Resources.united_kingdom;
                textboxSearch.HintText = "Search VietNamese";
                textboxSearch.Text = "Search VietNamese";
            }
            else
            {
                pictureBoxFlagLeft.Image = Dictionary_user.Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = Dictionary_user.Properties.Resources.vietnam;
                textboxSearch.HintText = "Search English";
                textboxSearch.Text = "Search English";
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
        }




        public MainForm() // Kích hoạt MainForm
        {
            //Initial GUI
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 34);
            panelMenu.Controls.Add(leftBorderBtn);
            activateMenuButton(iconButton1, RGBColors.color1);

            // Initialize Database
            myDictionary = new DictionaryManager();
            this.Controls.Add(myDictionary.VN);
            this.Controls.Add(myDictionary.EN);
        }

        protected override void OnLoad(EventArgs e)  //On Load
        {
            base.OnLoad(e);
            this.BeginInvoke(new MethodInvoker(delegate () { iconButton1.PerformClick(); }));
        }

        private void textboxSearch_OnValueChanged(object sender, EventArgs e) // Khi thay đổi giá trị textboxSearch 
        {
            if (textboxSearch.Text != string.Empty)
            {
                textboxSearch.LineIdleColor = RGBColors.color1;
            }
            if (textboxSearch.Text == string.Empty)
            {
                textboxSearch.LineIdleColor = textboxSearch.HintForeColor;
            }
            string command = "Use sql_invoicing; SELECT English from mytable where English like "+"'"+textboxSearch.Text+"%'";
            Database.load(command);
            int num = Database.loadData.Tables[0].Rows.Count;
            if (num > 0)
                labelHint1.Text = Database.loadData.Tables[0].Rows[0]["English"].ToString();
            else 
                labelHint1.Text = "";
            if (num > 1)
                labelHint2.Text = Database.loadData.Tables[0].Rows[1]["English"].ToString();
            else labelHint2.Text = "";
            if (num > 2)
                labelHint3.Text = Database.loadData.Tables[0].Rows[2]["English"].ToString();
            else
                labelHint3.Text = "";
            if (num > 3)
                labelHint4.Text = Database.loadData.Tables[0].Rows[2]["English"].ToString();
            else
                labelHint4.Text = "";

        }

        private void buttonSearch_Click(object sender, EventArgs e) // Khi click vào searchButton
        {
            if (textboxSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ cần tra vào chỗ trống!\nPlease insert the word that needs to be translated!");
            }
            else
            {
                activateSearchButton();
            }
        }

        private void buttonSwitch_Click(object sender, EventArgs e) // Khi click vào switchButton
        {
            if (ktSwitch == false)
                ktSwitch = true;
            else ktSwitch = false;
            activateSwitchButton();
        }

        private void iconButton1_Click(object sender, EventArgs e) // Khi click vào translateButton
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            activateMenuButton(sender, RGBColors.color1);
            displaySwitch();
            activateSwitchButton();
            displaySearch();
            textboxSearch.Text = textboxSearch.HintText;
            textboxSearch.LineFocusedColor = RGBColors.color1;
            textboxSearch.LineMouseHoverColor = RGBColors.color1;
            buttonSearch.IconColor = RGBColors.color1;
        }

        private void btnHistory_Click(object sender, EventArgs e) // Khi click vào historyButton
        {
            activateMenuButton(sender, RGBColors.color3);
            openChildForm(new History());
            hideSwitch();
            displaySearch();
            textboxSearch.HintText = "Search history";
            textboxSearch.Text = textboxSearch.HintText;
            textboxSearch.LineFocusedColor = RGBColors.color3;
            textboxSearch.LineMouseHoverColor = RGBColors.color3;
            buttonSearch.IconColor = RGBColors.color3;
        }

        private void btn_Bookmark_Click(object sender, EventArgs e) // Khi click vào bookmarkButton
        {
            activateMenuButton(sender, RGBColors.color2);
            openChildForm(new Bookmark());
            hideSwitch();
            displaySearch();
            textboxSearch.HintText = "Search bookmark";
            textboxSearch.Text = textboxSearch.HintText;
            textboxSearch.LineFocusedColor = RGBColors.color2;
            textboxSearch.LineMouseHoverColor = RGBColors.color2;
            buttonSearch.IconColor = RGBColors.color2;
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
            labelHint1.ForeColor = System.Drawing.Color.Gainsboro;
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
            labelHint2.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelHint2_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHint2.Text;
            activateSearchButton();
        }

        private void labelHint3_MouseHover(object sender, EventArgs e)
        {
            labelHint3.ForeColor = RGBColors.color7;
        }

        private void labelHint3_MouseLeave(object sender, EventArgs e)
        {
            labelHint3.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelHint3_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHint3.Text;
            activateSearchButton();
        }

        private void labelHint4_MouseHover(object sender, EventArgs e)
        {
            labelHint4.ForeColor = RGBColors.color7;
        }

        private void labelHint4_MouseLeave(object sender, EventArgs e)
        {
            labelHint4.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelHint4_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = labelHint4.Text;
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
                synth.Speak(textboxSearch.Text);
            }
        }

        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            if (ktBookmark == false)
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


        #endregion Search_Result

    }
}

