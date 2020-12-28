using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Dictionary_host
{
    public partial class Admin : Form
    {
        #region Declaration 
        private BusinessLogicTier.EN_VN_BUS EVDict = new BusinessLogicTier.EN_VN_BUS();
        private BusinessLogicTier.VN_EN_BUS VEDict = new BusinessLogicTier.VN_EN_BUS();
        private DictionaryDTO.EN_VN_Word currentEVWord = new DictionaryDTO.EN_VN_Word();
        private DictionaryDTO.VN_EN_Word currentVEWord = new DictionaryDTO.VN_EN_Word();

        private bool ktSwitch = false; // Kiểm tra chế độ Anh Việt hay Việt Anh
        private IconButton currentBtn; // Button đang được chọn hiện tại
        private Panel leftBorderLine; // nét nằm bên trái button đang chọn
        private Form currentChildForm; // Child form đang được mở hiện tại 
        private struct RGBColors // Struct các mã màu 
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(238, 26, 74);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(255, 244, 79);
            public static Color color8 = Color.DarkOrange;
        }

        public Admin()
        {
            InitializeComponent();
            leftBorderLine = new Panel();
            leftBorderLine.Size = new Size(7, 34);
            panelMenuButton.Controls.Add(leftBorderLine);
            activateMenuButton(btnAddNewWord, RGBColors.color1);
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
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (ktSwitch)
            {
                labelScreenName.Text = "Add New Word";
                labelKeyWord.Text = "Key:";
                labelPronunciation.Text = "Pronunciation:";
                labelWordType.Text = "Word type:";
                labelMeaning.Text = "Meaning:";
                labelExample.Text = "Example:";
                btnAdd.Text = "Add";

                textBoxKey.HintText = "Ex: Table,...";
                textBoxKey.Text = "";
                textBoxPronunciation.HintText = "//";
                textBoxPronunciation.Text = "";
                textBoxWordType.HintText = "Ex: Noun,...";
                textBoxWordType.Text = "";
                textBoxMean.HintText = "VD: Cái bàn,…";
                textBoxMean.Text = "";
                textBoxExample.HintText = "Ex: Swap the Table";
                textBoxExample.Text = "";

                pictureBoxFlagLeft.Image = Dictionary_host.Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = Dictionary_host.Properties.Resources.vietnam;
                ktSwitch = false;
            }
            else
            {
                labelScreenName.Text = "Thêm Từ Mới";
                labelKeyWord.Text = "Từ vựng";
                labelPronunciation.Text = "Phiên âm (nếu có):";
                labelWordType.Text = "Từ loại: ";
                labelMeaning.Text = "Nghĩa tiếng Anh:";
                labelExample.Text = "Ví dụ";

                btnAdd.Text = "Thêm";

                textBoxKey.HintText = "Xe buýt";
                textBoxKey.Text = "";
                textBoxPronunciation.HintText = "Xe bus";
                textBoxPronunciation.Text = "";
                textBoxWordType.HintText = "Danh từ";
                textBoxWordType.Text = "";
                textBoxMean.HintText = "Bus";
                textBoxMean.Text = "";
                textBoxExample.HintText = "The red bus has turned.";
                textBoxExample.Text = "";

                pictureBoxFlagLeft.Image = Dictionary_host.Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = Dictionary_host.Properties.Resources.united_kingdom;
                ktSwitch = true;
            }
            //if (currentChildForm != null)
            //{
            //    currentChildForm.Close();
            //    currentChildForm = null;
            //}
            //else
            //{

            //    iconButton13.Text = "Them tu moi";
            //    pictureBoxFlagLeft.Image = Dictionary_host.Properties.Resources.vietnam;
            //    pictureBoxFlagRight.Image = Dictionary_host.Properties.Resources.united_kingdom;
            //}

            //iconButton13.Text = "Thêm Từ Mới";
            //AddVnWord currentChildForm = new AddVnWord();
            //currentChildForm.TopLevel = false;
            //panelSuggestion.Controls.Add(currentChildForm);

            //currentChildForm.FormBorderStyle = FormBorderStyle.None;
            //currentChildForm.Dock = DockStyle.Fill;
            //panelSuggestion.Controls.Add(currentChildForm);
            //panelSuggestion.Tag = currentChildForm;
            //currentChildForm.BringToFront();
            //currentChildForm.Show();
        }

        private void disableMenuButton()  // restore hiển thị của button hiện hành 
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
            leftBorderLine.BackColor = color;
            leftBorderLine.Location = new Point(0, currentBtn.Location.Y);
            leftBorderLine.Visible = true;
            leftBorderLine.BringToFront();
            iconCurrentChildForm.IconChar = currentBtn.IconChar;
            iconCurrentChildForm.IconColor = color;
            labelTitleChildForm.Text = currentBtn.Text;
        }

        private void hideSwitch() // Ẩn chức năng chuyển ngôn ngữ
        {
            pictureBoxFlagLeft.Visible = false;
            pictureBoxFlagRight.Visible = false;
            buttonSwitch.Visible = false;
        }
        private void displaySwitch() // Hiển thị chức năng chuyển ngôn ngữ
        {
            buttonSwitch.Visible = true;
            pictureBoxFlagLeft.Visible = true;
            pictureBoxFlagRight.Visible = true;
        }

        private void hideSearch()
        {
            textboxSearch.Visible = false;
            buttonSearch.Visible = false;
        }
        private void displaySearch()
        {
            textboxSearch.Visible = true;
            buttonSearch.Visible = true;
        }

        private void btnAddNewWord_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
            activateMenuButton(sender, RGBColors.color1);
            if (!ktSwitch)
            {
                labelScreenName.Text = "Add New Word";
            }
            else
            {
                labelScreenName.Text = "Thêm Từ Mới";
            }
            displaySwitch();
            hideSearch();
        }

        private void btnUpdateWord_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            activateMenuButton(sender, RGBColors.color2);
            
            displaySwitch();
            displaySearch();

            if(!ktSwitch)
            {
                openChildForm(new UpdateWordForm(currentEVWord));
            }
            else
            {
                openChildForm(new UpdateWordForm(currentVEWord));
            }
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            activateMenuButton(sender, RGBColors.color3);
            openChildForm(new FeedBackForm());
            if (!ktSwitch)
            {
                labelScreenName.Text = "FeedBack";
            }
            else
            {
                labelScreenName.Text = "Phản Hồi";
            }
            hideSwitch();
            hideSearch();
        }
        
        private void btnSetting_Click(object sender, EventArgs e)
        {
            activateMenuButton(sender, RGBColors.color4);
            openChildForm(new SettingForm());
            if (!ktSwitch)
            {
                labelScreenName.Text = "Settings";
            }
            else
            {
                labelScreenName.Text = "Cài Đặt";
            }
            hideSwitch();
            hideSearch();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(textBoxKey.Text == "" || textBoxMean.Text == "" || textBoxWordType.Text == "")
            {
                if (ktSwitch)
                    MessageBox.Show("Vui lòng điền đầy đủ các trường cần thiết (từ vựng, nghĩa, từ loại)");
                else
                    MessageBox.Show("Please insert text in all required fields (key, meaning, wordtype)");
                return;
            }

            if(ktSwitch)
            {
                if(VEDict.searchWord(textBoxKey.Text) != null)
                {
                    MessageBox.Show("Từ này đã có trong từ điển!");
                    return;
                }
                DictionaryDTO.VN_EN_Word w = new DictionaryDTO.VN_EN_Word();

                w.VNKey = textBoxKey.Text;
                w.VNSuggestion = textBoxPronunciation.Text;
                w.WordType = textBoxWordType.Text;
                w.Means = textBoxMean.Text;
                w.Example = textBoxExample.Text;

                VEDict.addWord(w);
                btnClear_Click(null, null);
                MessageBox.Show("Thêm từ mới thành công");
            }
            else
            {
                if(EVDict.searchWord(textBoxKey.Text) != null)
                {
                    MessageBox.Show("This word is already in the dictionary!");
                    return;
                }
                DictionaryDTO.EN_VN_Word w = new DictionaryDTO.EN_VN_Word();

                w.ENKey = textBoxKey.Text;
                w.Pronounciation = textBoxPronunciation.Text;
                w.WordType = textBoxWordType.Text;
                w.Means = textBoxMean.Text;
                w.Example = textBoxExample.Text;

                EVDict.addWord(w);
                btnClear_Click(null, null);
                MessageBox.Show("Added new word successfully");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxKey.Text = "";
            textBoxMean.Text = "";
            textBoxWordType.Text = "";
            textBoxPronunciation.Text = "";
            textBoxExample.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(ktSwitch)
            {
                currentVEWord = VEDict.searchWord(textboxSearch.Text);
            }
            else
            {
                currentEVWord = EVDict.searchWord(textboxSearch.Text);
            }
            btnUpdateWord_Click(btnUpdateWord, null);
        }
    }
}
