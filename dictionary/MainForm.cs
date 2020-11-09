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

namespace dictionary
{
    public partial class MainForm : Form
    {
        #region Declaration and Initialization

        public DictionaryManager myDictionary;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private bool ktSwitch = false;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(238, 26, 74);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(255, 244, 79);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.BeginInvoke(new MethodInvoker(delegate () { iconButton1.PerformClick(); }));
        }

        public MainForm()
        {
            //Initial GUI
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 34);
            panelMenu.Controls.Add(leftBorderBtn);
            ActivateMenuButton(iconButton1, RGBColors.color1);

            // Initialize Database
            myDictionary = new DictionaryManager();
            this.Controls.Add(myDictionary.VN);
            this.Controls.Add(myDictionary.EN);
        }

        /* //Deleter windows bar
        this.Text = string.Empty;
        this.ControlBox = false;
        this.DoubleBuffered = true;
        this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        */

        #endregion

        #region Menu and Titlebar

        private void OpenChildForm(Form childForm)
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

        private void ActivateMenuButton(object senderBtn, Color color)
        {
            DisableMenuButton();
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

        private void DisableMenuButton()
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

        private void activatePictureBoxAndSwitchButton()
        {
            pictureBoxFlagLeft.Visible = true;
            pictureBoxFlagRight.Visible = true;
            buttonSwitch.Visible = true;
        }

        private void disablePictureBoxAndSwitchButton()
        {
            pictureBoxFlagLeft.Visible = false;
            pictureBoxFlagRight.Visible = false;
            buttonSwitch.Visible = false;
        }

        private void activateSearch()
        {
            textboxSearch.Visible = true;
            buttonSearch.Visible = true;
        }

        private void disableSearch()
        {
            textboxSearch.Visible = false;
            buttonSearch.Visible = false;
        }

        private void buttonSearchOnClick()
        {
            WordData result = myDictionary.Item.Data.Find(x => x.Key == textboxSearch.Text);
            if (result == null)
            {
                MessageBox.Show("No words found! I'm sorry.");
            }
            else
            {
                typedWord.Visible = true;
                typedWord.Text = textboxSearch.Text;
                labelResult.Visible = true;
                btnPlay.Visible = true;
            }
        }

        private void customizeTitleBar()
        {

        }

        private void buttonSwitchOnClick()
        {
            if (ktSwitch == true)
            {
                pictureBoxFlagLeft.Image = dictionary.Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = dictionary.Properties.Resources.united_kingdom;
                textboxSearch.HintText = "Search VietNamese";
                textboxSearch.Text = "Search VietNamese";
            }
            else
            {
                pictureBoxFlagLeft.Image = dictionary.Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = dictionary.Properties.Resources.vietnam;
                textboxSearch.HintText = "Search English";
                textboxSearch.Text = "Search English";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textboxSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ cần tra vào chỗ trống!\nPlease insert the word that needs to be translated!");
            }
            else
            {
                buttonSearchOnClick();
            }
        }

        private void textboxSearch_OnValueChanged(object sender, EventArgs e)
        {
            if (textboxSearch.Text != string.Empty)
            {
                textboxSearch.LineIdleColor = RGBColors.color1;
            }
            if (textboxSearch.Text == string.Empty)
            {
                textboxSearch.LineIdleColor = textboxSearch.HintForeColor;
            }
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (ktSwitch == false)
                ktSwitch = true;
            else ktSwitch = false;
            buttonSwitchOnClick();
        }

        private void iconButton1_Click(object sender, EventArgs e)// Translate Button
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActivateMenuButton(sender, RGBColors.color1);
            activatePictureBoxAndSwitchButton();
            buttonSwitchOnClick();
            activatePictureBoxAndSwitchButton();
            activateSearch();
            textboxSearch.Text = textboxSearch.HintText;
            textboxSearch.LineFocusedColor = RGBColors.color1;
            textboxSearch.LineMouseHoverColor = RGBColors.color1;
            buttonSearch.IconColor = RGBColors.color1;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(sender, RGBColors.color3);
            OpenChildForm(new History());
            disablePictureBoxAndSwitchButton();
            activateSearch();
            textboxSearch.HintText = "Search history";
            textboxSearch.Text = textboxSearch.HintText;
            textboxSearch.LineFocusedColor = RGBColors.color3;
            textboxSearch.LineMouseHoverColor = RGBColors.color3;
            buttonSearch.IconColor = RGBColors.color3;
        }

        private void btn_Bookmark_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(sender, RGBColors.color2);
            OpenChildForm(new Bookmark());
            disablePictureBoxAndSwitchButton();
            activateSearch();
            textboxSearch.HintText = "Search bookmark";
            textboxSearch.Text = textboxSearch.HintText;
            textboxSearch.LineFocusedColor = RGBColors.color2;
            textboxSearch.LineMouseHoverColor = RGBColors.color2;
            buttonSearch.IconColor = RGBColors.color2;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(sender, RGBColors.color4);
            OpenChildForm(new Settings());
            disableSearch();
            disablePictureBoxAndSwitchButton();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(sender, RGBColors.color5);
            OpenChildForm(new Help());
            disableSearch();
            disablePictureBoxAndSwitchButton();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(sender, RGBColors.color6);
            OpenChildForm(new Feedback());
            disableSearch();
            disablePictureBoxAndSwitchButton();
        }

        /* panelTitleBar_MouseDown
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
           ReleaseCapture();
           SendMessage(this.Handle, 0x112, 0xf012, 0);
        }*/

        #endregion

        #region Suggestion, History, Bookmark

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
            buttonSearchOnClick();
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
            buttonSearchOnClick();
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
            buttonSearchOnClick();
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
            buttonSearchOnClick();
        }

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
            buttonSearchOnClick();
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
            buttonSearchOnClick();
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
            buttonSearchOnClick();
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
            buttonSearchOnClick();
        }

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
            buttonSearchOnClick();
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
            buttonSearchOnClick();
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
            buttonSearchOnClick();
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
            buttonSearchOnClick();
        }

        #endregion

        #region Search_Result

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (textboxSearch.Text == "")
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
            }
        }

        #endregion
    }
}

