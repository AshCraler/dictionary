using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;
using FontAwesome.Sharp;

namespace Dictionary_user
{
    
    public partial class Feedback : Form
    {
        public FeedBack_BUS objFeedBack = new FeedBack_BUS();
        private DictionaryDTO.FeedBackDTO fb = new DictionaryDTO.FeedBackDTO();

        private IconButton currentButton; //button đang được chọn hiện tại   
        private Bunifu.Framework.UI.BunifuRating rating = new Bunifu.Framework.UI.BunifuRating();

        private Panel ratingPanel = new Panel();
        private Label ratingLabel = new Label();
        private Label ratingLabel2 = new Label();
        

        private void disableCurrentButton()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void activateTabButton(object senderBtn, Color c)
        {
            disableCurrentButton();

            //Button
            currentButton = (IconButton)senderBtn;
            currentButton.BackColor = Color.FromArgb(37, 36, 81);
            currentButton.ForeColor = c;
            currentButton.TextAlign = ContentAlignment.MiddleCenter;
            currentButton.IconColor = c;
            currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentButton.ImageAlign = ContentAlignment.MiddleRight;
            
        }
        
        private void disableCurrentControl()
        {
            contributePanel.Hide();
        }
        private void showContributeContent()
        {
            yourOpinionLabel.Text = "Your opinion:";
            
            contributePanel.Show();

        }
        private void showProblemReportContent()
        {
            yourOpinionLabel.Text = "Describe your \nproblem:";
            
            contributePanel.Show();
        }
        private void showRatingContent()
        {
            disableCurrentControl();
            ratingPanel.Show();
            ratingLabel.Show();
            rating.Show();

        }
        public Feedback()
        {
            
            InitializeComponent();
            
            activateTabButton(contributeButton, MainForm.RGBColors.color1);

            

        }

        private void Rating_onValueChanged(object sender, EventArgs e)
        {
            ratingLabel2.Show();
            switch (rating.Value)
            {
                case 1:
                    ratingLabel2.Text = "Worst";
                    break;
                case 2:
                    ratingLabel2.Text = "Bad";
                    break;
                case 3:
                    ratingLabel2.Text = "Normal";
                    break;
                case 4:
                    ratingLabel2.Text = "Well";
                    break;
                case 5:
                    ratingLabel2.Text = "Excellent!";
                    break;
                default:
                    break;
            }
        }

        

        private void buttonSendFeedBack_Click(object sender, EventArgs e)
        {
            fb.email = textBoxEmail.Text;
            fb.fullName = textBoxName.Text;
            fb.phoneNumber = textBoxPhoneNumber.Text;
            fb.content = textBoxContent.Text;

            if (objFeedBack.feedBack(fb))
                MessageBox.Show("Success");
        }


        

        

        private void problemReportButton_Click(object sender, EventArgs e)
        {
            activateTabButton(problemReportButton, MainForm.RGBColors.color2);
            showProblemReportContent();
        }

        private void contributeButton_Click(object sender, EventArgs e)
        {
            activateTabButton(contributeButton,MainForm.RGBColors.color1);
            showContributeContent();
        }
    }
}
