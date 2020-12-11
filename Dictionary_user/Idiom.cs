using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dictionary_user
{
    public partial class Idiom : Form
    {
        
        private bool ktSwitch = false;
        
        public Idiom()
        {
            InitializeComponent();
            textBoxResult.Cursor = Cursors.Arrow;
            textBox1.Cursor = Cursors.Arrow;
            textBox1.GotFocus += textBox_GotFocus;
            textBoxResult.GotFocus += textBox_GotFocus; 

        }
        private void textBox_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (ktSwitch == true)
            {
                ktSwitch = false;
                pictureBoxFlagLeft.Image = Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = Properties.Resources.united_kingdom;
                labelLanguage.Text = "Vietnamese Idiom";
            }
            else
            {
                ktSwitch = true;
                pictureBoxFlagLeft.Image = Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = Properties.Resources.vietnam;
                labelLanguage.Text = "English Idiom";
            }
        }
        private void panelSuggestion_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            iconBookmark.Visible = true;
            textBoxResult.Visible = true;
            textBoxMeaning.Visible = true;
            pictureBoxSearched.Visible = true;
            pictureBoxMeaning.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void textboxSearch_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
