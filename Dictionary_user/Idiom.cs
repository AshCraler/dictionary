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
        private string mode = "Book";
        private string command;
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

        public Idiom()
        {
            InitializeComponent();
            if (Database.BookandMore == 0)
            {
                mode = "book";
            }
            if (Database.BookandMore == 1)
            {
                mode = "idiom";
            }
            if (Database.BookandMore == 2)
            {
                mode = "luminary";
                labelLanguage.Text = "Vietnam ";
            }
            textboxSearch.HintText = "Search " + mode;
            textboxSearch.Text = "";
            textBoxResult.Text = "Searched " + mode;
            labelLanguage.Text = labelLanguage.Text.ToString() + mode;
        }
        
        private void resetSuggestionColor()
        {
            textBox1.ForeColor = Color.Gainsboro;
            textBox2.ForeColor = Color.Gainsboro;
            textBox3.ForeColor = Color.Gainsboro;
            textBox4.ForeColor = Color.Gainsboro;
        }
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (ktSwitch == true)
            {
                ktSwitch = false;
                pictureBoxFlagLeft.Image = Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = Properties.Resources.united_kingdom;
                labelLanguage.Text = "Vietnamese "+mode;
                if (Database.BookandMore == 2)
                    labelLanguage.Text = "Vietnam luminary";
            }
            else
            {
                ktSwitch = true;
                pictureBoxFlagLeft.Image = Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = Properties.Resources.vietnam;
                labelLanguage.Text = "English "+mode;
                if (Database.BookandMore == 2)
                    labelLanguage.Text = "World luminary";
            }
        }
        private void panelSuggestion_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textboxSearch.Text == "")
            {
                MessageBox.Show("Please insert the "+mode+ " that needs to be searched !");
            }
            else
            {
                iconBookmark.Visible = true;
                textBoxResult.Visible = true;
                textBoxMeaning.Visible = true;
                pictureBoxSearched.Visible = true;
                pictureBoxMeaning.Visible = true;
                command = "SELECT * from viebook where book= " + "'" + textboxSearch.Text.ToString() + "'";
                Database.load(command);
                if (Database.loadData.Rows.Count > 0)
                {
                    textBoxResult.Text = Database.loadData.Rows[0]["book"].ToString();
                    textBoxMeaning.Text = Database.loadData.Rows[0]["link"].ToString();
                }
                else
                {
                    textBoxResult.Text = textboxSearch.Text;
                    textBoxMeaning.Text = "Not Found";
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textboxSearch.Text = textBox1.Text;
        }

        private void textboxSearch_OnValueChanged(object sender, EventArgs e)
        {
            resetSuggestionColor();
            if (textboxSearch.Text != string.Empty)
            {
                textboxSearch.LineIdleColor = RGBColors.color1;
            }
            if (textboxSearch.Text == string.Empty)
            {
                textboxSearch.LineIdleColor = textboxSearch.HintForeColor;
            }
            command = "Use sql_invoicing; SELECT " + mode + " from viebook where " + mode + " like " + "'" + textboxSearch.Text + "%'";
            Database.load(command);
            int num = Database.loadData.Rows.Count;
            if (num > 0)
                textBox1.Text = Database.loadData.Rows[0][mode].ToString();
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
            }
            if (num > 1)
                textBox2.Text = Database.loadData.Rows[1][mode].ToString();
            else
            {
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
            }
            if (num > 2)
                textBox4.Text = Database.loadData.Rows[2][mode].ToString();
            else
            {
                textBox4.Text = "";
                textBox3.Text = "";
            }
            if (num > 3)
                textBox3.Text = Database.loadData.Rows[3][mode].ToString();
            else
                textBox3.Text = "";
        }
   
        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = textBox2.Text;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = textBox3.Text;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = textBox4.Text;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox6.Text;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox7.Text;
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox8.Text;
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox9.Text;
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox11.Text;
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox12.Text;
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox13.Text;
        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox14.Text;
        }

        private void textBox15_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox15.Text;
        }

        private void textBox16_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox16.Text;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.FromArgb(255, 244, 79);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gainsboro;
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.FromArgb(255, 244, 79);
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Gainsboro;
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.FromArgb(255, 244, 79);
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Gainsboro;
        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.FromArgb(255, 244, 79);
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.Gainsboro;
        }

        private void textBox6_MouseHover(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void textBox6_MouseLeave(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.Gainsboro;
        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            textBox7.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void textBox7_MouseLeave(object sender, EventArgs e)
        {
            textBox7.ForeColor = Color.Gainsboro;
        }

        private void textBox8_MouseHover(object sender, EventArgs e)
        {
            textBox8.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void textBox8_MouseLeave(object sender, EventArgs e)
        {
            textBox8.ForeColor = Color.Gainsboro;
        }

        private void textBox9_MouseHover(object sender, EventArgs e)
        {
            textBox9.ForeColor = Color.FromArgb(238, 26, 74);
        }

        private void textBox9_MouseLeave(object sender, EventArgs e)
        {
            textBox9.ForeColor = Color.Gainsboro;
        }

        private void textBox11_MouseHover(object sender, EventArgs e)
        {
            textBox11.ForeColor = Color.FromArgb(242, 98, 121);
        }

        private void textBox11_MouseLeave(object sender, EventArgs e)
        {
            textBox11.ForeColor = Color.Gainsboro;
        }

        private void textBox12_MouseHover(object sender, EventArgs e)
        {
            textBox12.ForeColor = Color.FromArgb(242, 98, 121);
        }

        private void textBox12_MouseLeave(object sender, EventArgs e)
        {
            textBox12.ForeColor = Color.Gainsboro;
        }

        private void textBox13_MouseHover(object sender, EventArgs e)
        {
            textBox13.ForeColor = Color.FromArgb(242, 98, 121);
        }

        private void textBox13_MouseLeave(object sender, EventArgs e)
        {
            textBox13.ForeColor = Color.Gainsboro;
        }

        private void textBox14_MouseHover(object sender, EventArgs e)
        {
            textBox14.ForeColor = Color.FromArgb(242, 98, 121);
        }

        private void textBox14_MouseLeave(object sender, EventArgs e)
        {
            textBox14.ForeColor = Color.Gainsboro;
        }

        private void textBox15_MouseHover(object sender, EventArgs e)
        {
            textBox15.ForeColor = Color.FromArgb(242, 98, 121);
        }

        private void textBox15_MouseLeave(object sender, EventArgs e)
        {
            textBox15.ForeColor = Color.Gainsboro;
        }

        private void textBox16_MouseHover(object sender, EventArgs e)
        {
            textBox16.ForeColor = Color.FromArgb(242, 98, 121);
        }

        private void textBox16_MouseLeave(object sender, EventArgs e)
        {
            textBox16.ForeColor = Color.Gainsboro;
        }

        private void textBoxMeaning_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(textBoxMeaning.Text.ToString());
        }

        private void textBoxMeaning_MouseHover(object sender, EventArgs e)
        {
            textBoxMeaning.ForeColor = Color.FromArgb(24, 161, 251);
        }

        private void textBoxMeaning_MouseLeave(object sender, EventArgs e)
        {
            textBoxMeaning.ForeColor = Color.Gainsboro;
        }
    }
}
