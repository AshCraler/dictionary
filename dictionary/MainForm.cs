using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public DictionaryManager myDictionary;
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private bool ktSwitch = false;
 
      

        //Constructor  
        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,34);
            panelMenu.Controls.Add(leftBorderBtn);
          
            //Form
          /*  this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;*/
            myDictionary = new DictionaryManager();
            myDictionary.loadFirstDataToSuggestionPanel(suggestedWordComboBox);
            this.Controls.Add(myDictionary.VN);
            this.Controls.Add(myDictionary.EN);      
        }
        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
            this.BeginInvoke(new MethodInvoker(delegate () { iconButton1.PerformClick(); }));

        }
        //Structs
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
        
        //Method
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
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
        }
        private void DisableButton()
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

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
          //  lblTitleChildForm.Text = childForm.Text;
        }
        

        
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

       





























        private void textboxSearch_TextChanged(object sender, EventArgs e){}
        private void nameLabel_Click(object sender, EventArgs e){}

        private void iconButton3_Click(object sender, EventArgs e){}

        private void panel1_Paint(object sender, PaintEventArgs e){}

        private void MainForm_Load(object sender, EventArgs e){}

        private void iconButton1_Click(object sender, EventArgs e)// Button Home
        {
            ActivateButton(sender, RGBColors.color1);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
              //  Reset();
            }
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new History());
            
        }

        private void btn_Bookmark_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Bookmark());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Settings());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Help());
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Feedback());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           // Reset();
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textboxSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ cần tra vào chỗ trống!\nPlease insert the word that needs to be translated!");
            }
            else
            {
                WordData result = myDictionary.Item.Data.Find(x => x.Key == textboxSearch.Text);
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

        private void meaningRichTextBox_TextChanged(object sender, EventArgs e)
        {}

        private void textboxSearch_OnValueChanged(object sender, EventArgs e)
        {
            if (textboxSearch.Text != string.Empty)
            {
                textboxSearch.LineIdleColor = RGBColors.color1;
            }
            if (textboxSearch.Text == string.Empty)
            {
                textboxSearch.LineIdleColor = textboxSearch.HintForeColor ;
            }
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (ktSwitch == false)
            {
                ktSwitch = true;
          //      suggestedWordComboBox.DisplayMember = "Meaning";
                pictureBoxFlagLeft.Image = dictionary.Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = dictionary.Properties.Resources.united_kingdom;
                textboxSearch.HintText = "Search VietNamese";
                textboxSearch.Text = "Search VietNamese";
            }
            else
            {
                ktSwitch = false;
     //           suggestedWordComboBox.DisplayMember = "Key";
                pictureBoxFlagLeft.Image = dictionary.Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = dictionary.Properties.Resources.vietnam;
                textboxSearch.HintText = "Search English";
                textboxSearch.Text = "Search English";
            }
        }

        private void textboxSearch_DoubleClick(object sender, EventArgs e)
        {

        }

        private void labelHint1_MouseHover(object sender, EventArgs e)
        {
            labelHint1.ForeColor = RGBColors.color7;
        }
        private void labelHint1_MouseLeave(object sender, EventArgs e)
        {
            labelHint1.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelHint2_MouseHover(object sender, EventArgs e)
        {
            labelHint2.ForeColor = RGBColors.color7;
        }

        private void labelHint2_MouseLeave(object sender, EventArgs e)
        {
            labelHint2.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelHint3_MouseHover(object sender, EventArgs e)
        {
            labelHint3.ForeColor = RGBColors.color7;
        }

        private void labelHint3_MouseLeave(object sender, EventArgs e)
        {
            labelHint3.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void labelHint4_MouseHover(object sender, EventArgs e)
        {
            labelHint4.ForeColor = RGBColors.color7;
        }

        private void labelHint4_MouseLeave(object sender, EventArgs e)
        {
            labelHint4.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new Translate());
        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void labelHint_Click(object sender, EventArgs e)
        {

        }

        private void labelHint2_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }






        /* private void Reset()
{
DisableButton();
leftBorderBtn.Visible = false;
iconCurrentChildForm.IconChar = IconChar.Home;
iconCurrentChildForm.IconColor = Color.MediumPurple;
lblTitleChildForm.Text = "Home";
}*/
    }
}
