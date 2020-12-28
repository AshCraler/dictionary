using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_host
{
    public partial class Admin : Form
    {
        #region Declaration 
        private bool ktSwitch = false; // Kiểm tra chế độ Anh Việt hay Việt Anh
        private Form currentChildForm; // Child form đang được mở hiện tại 
        public Admin()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm) // Mở childForm mới
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            else
            {
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
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
        #endregion
    }
}
