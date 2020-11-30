using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
//using System.Speech.Synthesis;
using FontAwesome.Sharp;
using System.Data;
//using MySql.Data;
//using MySql.Data.MySqlClient;

namespace Dictionary_host
{
    public partial class Admin : Form
    {
        #region Declaration 
        private bool ktSwitch = false; // Kiểm tra chế độ Anh Việt hay Việt Anh
        private IconButton currentBtn; // Button đang được chọn hiện tại
        private Panel leftBorderBtn; // Panel chứa các chức năng chính
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
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 34);
            panelChildForm.Controls.Add(leftBorderBtn);
            activateMenuButton(iconButton1, RGBColors.color8);
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
                iconButton13.Text = "Add New Word";
                iconButton9.Text = "Key";
                iconButton10.Text = "Pronunciation";
                iconButton11.Text = "Word Type";
                iconButton8.Text = "VietNamese";
                iconButton12.Text = "Example";
                iconButton1.Text = "Add New";
                bunifuMaterialTextbox1.HintText = "Ex: Table,...";
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox2.HintText = "//";
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox3.HintText = "Ex: Noun,...";
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox4.HintText = "VD: Cái bàn,…";
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox5.HintText = "Ex: Swap the Table";
                bunifuMaterialTextbox5.Text = "";
                pictureBoxFlagLeft.Image = Dictionary_host.Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = Dictionary_host.Properties.Resources.vietnam;
                ktSwitch = false;
            }
            else
            {
                iconButton13.Text = "Thêm Từ Mới";
                iconButton9.Text = "Thêm Từ Mới";
                iconButton10.Text = "Từ đồng nghĩa";
                iconButton11.Text = "Từ Loại ";
                iconButton8.Text = "English";
                iconButton12.Text = "Ví Dụ";
                iconButton1.Text = "Thêm";
                bunifuMaterialTextbox1.HintText = "VD: Cái ví,…";
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox2.HintText = "Cái bóp";
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox3.HintText = "Danh từ";
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox4.HintText = "Wallet";
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox5.HintText = "Em có bán ví đâu mà sao các anh cứ tìm chỗ để bóp";
                bunifuMaterialTextbox5.Text = "";
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
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
            activateMenuButton(sender, RGBColors.color1);
            if (!ktSwitch)
            {
                iconButton13.Text = "Add New Word";
            }
            else
            {
                iconButton13.Text = "Thêm Từ Mới";
            }
            displaySwitch();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            activateMenuButton(sender, RGBColors.color3);
            openChildForm(new FeedBack());
            if (!ktSwitch)
            {
                iconButton13.Text = "FeedBack";
            }
            else
            {
                iconButton13.Text = "Phản Hồi";
            }
            hideSwitch();
        }
        #endregion

        private void iconButton7_Click(object sender, EventArgs e)
        {
            activateMenuButton(sender, RGBColors.color6);
            openChildForm(new Setting());
            if (!ktSwitch)
            {
                iconButton13.Text = "Settings";
            }
            else
            {
                iconButton13.Text = "Cài Đặt";
            }
            hideSwitch();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
