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
        private string mode = "book";
        private string language = "vie";
        private string time;
        private string command;
        private bool ktBookmark;
        private string link1, link2, link3, link4;
        private int page = 0;
        private bool[] check = new bool[100000];
        private int suggestionRowCount;
        private int bookmarkRowCount;
        private int historyRowCount;

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
        private void reloadBookmark()
        {
            page = 0;
            command = "select * from bookbookmark order by id DESC";
            loadDatabase(command);
            loadSuggestionBookmark();
            loadPageInfo();
        }
        private void loadDatabase(string cmd)
        {
            Database.load(cmd);
            for (int i = 0; i < 100000; i++)
                check[i] = true;
        }
        private void resetSuggestionColor()
        {
            textBox1.ForeColor = Color.Gainsboro;
            textBox2.ForeColor = Color.Gainsboro;
            textBox3.ForeColor = Color.Gainsboro;
            textBox4.ForeColor = Color.Gainsboro;
        }
        private void resetSuggestionBookmarkColor()
        {
            textBox6.ForeColor = Color.Gainsboro;
            textBox7.ForeColor = Color.Gainsboro;
            textBox8.ForeColor = Color.Gainsboro;
            textBox9.ForeColor = Color.Gainsboro;
        }
        private void reseticonButtonSuggestionBookmarkColor()
        {
            iconButton1.IconColor= RGBColors.color2;
            iconButton2.IconColor = RGBColors.color2;
            iconButton3.IconColor = RGBColors.color2;
            iconButton4.IconColor = RGBColors.color2;
        }

        private void loadSuggestion()
        {
            if (textboxSearch.Text != string.Empty)
            {
                textboxSearch.LineIdleColor = RGBColors.color1;
            }
            if (textboxSearch.Text == string.Empty)
            {
                textboxSearch.LineIdleColor = textboxSearch.HintForeColor;
            }
            command = "Use sql_invoicing; SELECT " + mode + " from " + language + "book where " + mode + " like " + "\"" + textboxSearch.Text + "%\"";
            Database.load(command);
            int num = Database.loadData.Rows.Count;
            if (num > 0)
            {
                textBox1.Text = Database.loadData.Rows[0][mode].ToString();
                textBox1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            if (num > 1)
            {
                textBox2.Visible = true;
                textBox2.Text = Database.loadData.Rows[1][mode].ToString();
            }
            else
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            if (num > 2)
            {
                textBox3.Visible = true;
                textBox3.Text = Database.loadData.Rows[2][mode].ToString();
            }
            else
            {
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            if (num > 3)
            {
                textBox4.Visible = true;
                textBox4.Text = Database.loadData.Rows[3][mode].ToString();
            }
            else
                textBox4.Visible = false;
        }
        
        private void loadDefaultSuggestion()
        {
            textboxSearch.HintText = "Search " + mode;
            textboxSearch.Text = "";
            textBoxResult.Text = "Searched " + mode;
            labelLanguage.Text = labelLanguage.Text.ToString() + mode;
        }
        
        private void loadSuggestionBookmark()
        {
            if (textboxSearch.Text != string.Empty)
            {
                textboxBookmark.LineIdleColor = RGBColors.color2;
            }
            if (textboxSearch.Text == string.Empty)
            {
                textboxBookmark.LineIdleColor = textboxSearch.HintForeColor;
            }
            command = "Use sql_invoicing; SELECT * from bookbookmark where " + mode + " like " + "\"" + textboxBookmark.Text + "%\"";
            Database.load(command);
            int num = Database.loadData.Rows.Count;
            if (num > 0+4*page)
            {
                iconButton1.Visible = true;
                textBox6.Visible = true;
                textBox6.Text = Database.loadData.Rows[page*4][mode].ToString();
                link1 = Database.loadData.Rows[page*4]["link"].ToString();
            }
            else
            {
                iconButton1.Visible = false;
                iconButton2.Visible = false;
                iconButton3.Visible = false;
                iconButton4.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
            }
            if (num > 1+4*page)
            {
                iconButton2.Visible = true;
                textBox7.Visible = true;
                textBox7.Text = Database.loadData.Rows[page*4+1][mode].ToString();
                link2 = Database.loadData.Rows[page*4+1]["link"].ToString();
            }
            else
            {
                iconButton2.Visible = false;
                iconButton3.Visible = false;
                iconButton4.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
            }
            if (num > 2+4*page)
            {
                iconButton3.Visible = true;
                textBox8.Visible = true;
                textBox8.Text = Database.loadData.Rows[page*4+2][mode].ToString();
                link3 = Database.loadData.Rows[page*4+2]["link"].ToString();
            }
            else
            {
                iconButton3.Visible = false;
                iconButton4.Visible = false;
                textBox8.Visible=false;
                textBox9.Visible=false;
            }
            if (num > 3+4*page)
            {

                iconButton4.Visible = true;
                textBox9.Visible = true;
                textBox9.Text = Database.loadData.Rows[page*4+3][mode].ToString();
                link4 = Database.loadData.Rows[page*4+3]["link"].ToString();
            }
            else
            {
                textBox9.Visible = false;
                iconButton4.Visible = false;
            }
        }

        private void loadBookmark()
        {
            command = " SELECT book from bookbookmark where book = " + "\"" + textBoxResult.Text.ToString() + "\""; //+ "and languages= " + "'" + hint + "'";
            Database.load(command);
            if (Database.loadData.Rows.Count > 0)
            {
                ktBookmark = true;
                iconBookmark.IconColor = RGBColors.color7;
            }
            else
            {
                ktBookmark = false;
                iconBookmark.IconColor = Color.Gainsboro;
            }
        }

        private void loadPageInfo()
        {
            string max;
            if ((page + 1) * 4 < Database.loadData.Rows.Count)
                max = ((page + 1) * 4).ToString();
            else max = Database.loadData.Rows.Count.ToString();
            if (Database.loadData.Rows.Count == 0)
                pageInfo.Visible = false;
            else
                pageInfo.Visible = true;
            pageInfo.Text = (page * 4 + 1).ToString() + " - " + max + " / " + Database.loadData.Rows.Count.ToString() + " " + mode;
        }
        

        public Idiom()
        {
            InitializeComponent();
            reloadBookmark();
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
            loadDefaultSuggestion();
            suggestionRowCount = Database.loadData.Rows.Count;
            loadSuggestionBookmark();
            bookmarkRowCount = Database.loadData.Rows.Count;
        }
        
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (ktSwitch == true)
            {
                ktSwitch = false;
                pictureBoxFlagLeft.Image = Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = Properties.Resources.united_kingdom;
                labelLanguage.Text = "Vietnamese "+mode;
                language = "vie";
                if (Database.BookandMore == 2)
                    labelLanguage.Text = "Vietnam luminary";
            }
            else
            {
                ktSwitch = true;
                pictureBoxFlagLeft.Image = Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = Properties.Resources.vietnam;
                labelLanguage.Text = "English "+mode;
                language = "eng";
                if (Database.BookandMore == 2)
                    labelLanguage.Text = "World luminary";
            }
            loadSuggestion();
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
                command = "SELECT * from "+language+"book where book= " + "\"" + textboxSearch.Text.ToString() + "\"";
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
            loadBookmark();
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
            loadSuggestion();
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

        private void iconBookmark_Click(object sender, EventArgs e)
        {
            time=DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (ktBookmark == false)
            {
                ktBookmark = true;
                iconBookmark.IconColor = RGBColors.color7;
                Database.insertBookBookmark(textBoxResult.Text, textBoxMeaning.Text, time);
             //   if (hint == "English")
             //       Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Eng-Vie'");
             //   else
             //       Database.updateHistory("update historysearch set bookmark = " + "'" + "Yes" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Vie-Eng'");
             //   loadRecentlyBookmark();
            }
            else
            {
                ktBookmark = false;
                iconBookmark.IconColor = Color.Gainsboro;
                command = "delete from bookbookmark where "+mode +"=" + "'" + textBoxResult.Text + "'";//+ "AND languages=" + "'" + hint + "'";
                Database.deleteBookmark(command);
              //  if (hint == "English")
              //      Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Eng-Vie'");
              //  else
              //      Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " + "'" + typedWord.Text + "'" + "AND Translate='Vie-Eng'");
              //  loadRecentlyBookmark();
            }
        }

        private void textboxBookmark_OnValueChanged(object sender, EventArgs e)
        {
            loadSuggestionBookmark();
            resetSuggestionBookmarkColor();
            reseticonButtonSuggestionBookmarkColor();
            loadPageInfo();
        }

        private void iconButtonSearchBookmark_Click(object sender, EventArgs e)
        {
            if (textboxBookmark.Text == "")
            {
                MessageBox.Show("Please insert the " + mode + " that needs to be searched !");
            }
            else
            {
                iconBookmark.Visible = true;
                textBoxResult.Visible = true;
                textBoxMeaning.Visible = true;
                pictureBoxSearched.Visible = true;
                pictureBoxMeaning.Visible = true;
                command = "SELECT * from bookbookmark where book= " + "\"" + textboxBookmark.Text.ToString() + "\"";
                Database.load(command);
                if (Database.loadData.Rows.Count > 0)
                {
                    textBoxResult.Text = Database.loadData.Rows[0]["book"].ToString();
                    textBoxMeaning.Text = Database.loadData.Rows[0]["link"].ToString();
                }
                else
                {
                    textBoxResult.Text = textboxBookmark.Text;
                    textBoxMeaning.Text = "Not Found";
                }
                loadBookmark();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            time= DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (iconButton1.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookbookmark where book =" + "\"" + textBox6.Text + "\"";
                Database.deleteBookmark(command);
                iconButton1.IconColor = Color.Gainsboro;
                //check[page * 13 + 1] = false;
            }
            else
            {
                iconButton1.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookBookmark(textBox6.Text,link1 , time);
               // check[page * 13 + 1] = true;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (iconButton2.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookbookmark where book =" + "\"" + textBox7.Text + "\"";
                Database.deleteBookmark(command);
                iconButton2.IconColor = Color.Gainsboro;
                //check[page * 13 + 1] = false;
            }
            else
            {
                iconButton2.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookBookmark(textBox7.Text, link2, time);
                // check[page * 13 + 1] = true;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (iconButton3.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookbookmark where book =" + "\"" + textBox8.Text + "\"";
                Database.deleteBookmark(command);
                iconButton3.IconColor = Color.Gainsboro;
                //check[page * 13 + 1] = false;
            }
            else
            {
                iconButton3.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookBookmark(textBox8.Text, link3, time);
                // check[page * 13 + 1] = true;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (iconButton4.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookbookmark where book =" + "\"" + textBox9.Text + "\"";
                Database.deleteBookmark(command);
                iconButton4.IconColor = Color.Gainsboro;
                //check[page * 13 + 1] = false;
            }
            else
            {
                iconButton4.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookBookmark(textBox9.Text, link4, time);
                // check[page * 13 + 1] = true;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if ((page + 1) * 4 < bookmarkRowCount)
            {
                page = page + 1;
                loadPageInfo();
                loadSuggestionBookmark();
            }
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page = page - 1;
                loadPageInfo();
                loadSuggestionBookmark();
            }
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            reloadBookmark();
        }
    }
}
