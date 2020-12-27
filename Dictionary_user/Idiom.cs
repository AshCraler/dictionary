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
        #region Declaration

        private bool ktSwitch = false;
        private string mode = "Book";
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
        private DataTable bookmarkData;
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

        #endregion

        #region Search

        private string historytime11;
        private string historytime12;
        private string historytime13;
        private string historytime14;
        private string historytime15;
        private string historytime16;

        private void activateButtonSearch()
        {
            if (textboxSearch.Text == "")
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
                command = "SELECT * from " + language + mode + " where " + mode + " = " + "\"" + textboxSearch.Text.ToString() + "\"";
                Database.load(command);
                if (Database.loadData.Rows.Count > 0)
                {
                    textBoxResult.Text = Database.loadData.Rows[0][mode].ToString();
                    textBoxMeaning.Text = Database.loadData.Rows[0]["link"].ToString();
                }
                else
                {
                    textBoxResult.Text = textboxSearch.Text;
                    textBoxMeaning.Text = "Not Found";
                }
                time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
                if (mode == "Book")
                    Database.insertBookhistory(textBoxResult.Text, textBoxMeaning.Text, time);
                if (mode == "Idiom")
                    Database.insertIdiomhistory(textBoxResult.Text, textBoxMeaning.Text, time);
                if (mode == "Luminary")
                    Database.insertLuminaryhistory(textBoxResult.Text, textBoxMeaning.Text, time);
            }
            loadBookmark();
            textboxBookmark.Text = "";
            textboxHistory.Text = "";
        }
        
        private void activateIconButtonSearchBookmark()
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
                command = "SELECT * from " + mode + "bookmark where " + mode + "= " + "\"" + textboxBookmark.Text.ToString() + "\"";
                Database.load(command);
                if (Database.loadData.Rows.Count > 0)
                {
                    textBoxResult.Text = Database.loadData.Rows[0][mode].ToString();
                    textBoxMeaning.Text = Database.loadData.Rows[0]["link"].ToString();
                }
                else
                {
                    textBoxResult.Text = textboxBookmark.Text;
                    textBoxMeaning.Text = "Not Found";
                }
                time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
                if (mode == "Book")
                    Database.insertBookhistory(textBoxResult.Text, textBoxMeaning.Text, time);
                if (mode == "Idiom")
                    Database.insertIdiomhistory(textBoxResult.Text, textBoxMeaning.Text, time);
                if (mode == "Luminary")
                    Database.insertLuminaryhistory(textBoxResult.Text, textBoxMeaning.Text, time);
                loadBookmark();
                textboxSearch.Text = "";
                textboxHistory.Text = "";
            }
        }
        
        private void activateIconButtonSearchHistory()
        {
            if (textboxHistory.Text == "")
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
                command = "SELECT * from " + "eng" + mode + " where " + mode + "= " + "\"" + textboxHistory.Text.ToString() + "\"";
                Database.load(command);
                if (Database.loadData.Rows.Count > 0)
                {
                    textBoxResult.Text = Database.loadData.Rows[0][mode].ToString();
                    textBoxMeaning.Text = Database.loadData.Rows[0]["link"].ToString();
                }
                else
                {
                    command = "SELECT * from " + "vie" + mode + " where " + mode + "= " + "\"" + textboxHistory.Text.ToString() + "\"";
                    Database.load(command);
                    if (Database.loadData.Rows.Count > 0)
                    {
                        textBoxResult.Text = Database.loadData.Rows[0][mode].ToString();
                        textBoxMeaning.Text = Database.loadData.Rows[0]["link"].ToString();
                    }
                    else
                    {
                        textBoxResult.Text = textboxHistory.Text;
                        textBoxMeaning.Text = "Not Found";
                    }
                }
                loadBookmark();
                time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
                if (mode == "Book")
                    Database.insertBookhistory(textBoxResult.Text, textBoxMeaning.Text, time);
                if (mode == "Idiom")
                    Database.insertIdiomhistory(textBoxResult.Text, textBoxMeaning.Text, time);
                if (mode == "Luminary")
                    Database.insertLuminaryhistory(textBoxResult.Text, textBoxMeaning.Text, time);
                textboxSearch.Text = "";
                textboxBookmark.Text = "";
            }
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
            iconButton1.IconColor = RGBColors.color2;
            iconButton2.IconColor = RGBColors.color2;
            iconButton3.IconColor = RGBColors.color2;
            iconButton4.IconColor = RGBColors.color2;
        }

        private void resetSuggestionHistoryColor()
        {
            textBox11.ForeColor = Color.Gainsboro;
            textBox12.ForeColor = Color.Gainsboro;
            textBox13.ForeColor = Color.Gainsboro;
            textBox14.ForeColor = Color.Gainsboro;
            textBox15.ForeColor = Color.Gainsboro;
            textBox16.ForeColor = Color.Gainsboro;
        }

        private void loadSearchSuggestion()
        {
            if (textboxSearch.Text != string.Empty)
            {
                textboxSearch.LineIdleColor = RGBColors.color1;
            }
            if (textboxSearch.Text == string.Empty)
            {
                textboxSearch.LineIdleColor = textboxSearch.HintForeColor;
            }
            command = "Use sql_invoicing; SELECT " + mode + " from " + language + mode + " where " + mode + " like " + "\"" + textboxSearch.Text + "%\"";
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

        private void loadSearchSuggestionBookmark()
        {
            if (textboxSearch.Text != string.Empty)
            {
                textboxBookmark.LineIdleColor = RGBColors.color2;
            }
            if (textboxSearch.Text == string.Empty)
            {
                textboxBookmark.LineIdleColor = textboxSearch.HintForeColor;
            }
            int num = bookmarkRowCount;
            if (num > 0 + 4 * page)
            {
                iconButton1.Visible = true;
                textBox6.Visible = true;
                textBox6.Text =bookmarkData.Rows[page * 4][mode].ToString();
                link1 = bookmarkData.Rows[page * 4]["link"].ToString();
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
            if (num > 1 + 4 * page)
            {
                iconButton2.Visible = true;
                textBox7.Visible = true;
                textBox7.Text = bookmarkData.Rows[page * 4 + 1][mode].ToString();
                link2 = bookmarkData.Rows[page * 4 + 1]["link"].ToString();
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
            if (num > 2 + 4 * page)
            {
                iconButton3.Visible = true;
                textBox8.Visible = true;
                textBox8.Text = bookmarkData.Rows[page * 4 + 2][mode].ToString();
                link3 = bookmarkData.Rows[page * 4 + 2]["link"].ToString();
            }
            else
            {
                iconButton3.Visible = false;
                iconButton4.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
            }
            if (num > 3 + 4 * page)
            {

                iconButton4.Visible = true;
                textBox9.Visible = true;
                textBox9.Text = bookmarkData.Rows[page * 4 + 3][mode].ToString();
                link4 = bookmarkData.Rows[page * 4 + 3]["link"].ToString();
            }
            else
            {
                textBox9.Visible = false;
                iconButton4.Visible = false;
            }
        
        }

        private void loadSearchSuggestionHistory()
        {
            if (textboxSearch.Text != string.Empty)
            {
                textboxSearch.LineIdleColor = RGBColors.color1;
            }
            if (textboxSearch.Text == string.Empty)
            {
                textboxSearch.LineIdleColor = textboxSearch.HintForeColor;
            }
            command = "Use sql_invoicing; SELECT * from "+ mode +"history where " + mode + " like " + "\"" + textboxHistory.Text + "%\""+"order by id desc";
            Database.load(command);
            int num = Database.loadData.Rows.Count;
            if (num > 0)
            {
                textBox11.Text = Database.loadData.Rows[0][mode].ToString();
                historytime11 = Database.loadData.Rows[0]["Time"].ToString();
                textBox11.Visible = true;
                iconButton7.Visible = true;
            }
            else
            {
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                iconButton7.Visible = false;
                iconButton8.Visible = false;
                iconButton9.Visible = false;
                iconButton10.Visible = false;
                iconButton11.Visible = false;
                iconButton12.Visible = false;
            }
            if (num > 1)
            {
                textBox12.Visible = true;
                historytime12 = Database.loadData.Rows[1]["Time"].ToString();
                textBox12.Text = Database.loadData.Rows[1][mode].ToString();
                iconButton8.Visible = true;
            }
            else
            {
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                iconButton8.Visible = false;
                iconButton9.Visible = false;
                iconButton10.Visible = false;
                iconButton11.Visible = false;
                iconButton12.Visible = false;
            }
            if (num > 2)
            {
                textBox13.Visible = true;
                historytime13 = Database.loadData.Rows[2]["Time"].ToString();
                textBox13.Text = Database.loadData.Rows[2][mode].ToString();
                iconButton9.Visible = true;
            }
            else
            {
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                iconButton9.Visible = false;
                iconButton10.Visible = false;
                iconButton11.Visible = false;
                iconButton12.Visible = false;
            }
            if (num > 3)
            {
                textBox14.Visible = true;
                textBox14.Text = Database.loadData.Rows[3][mode].ToString();
                historytime14 = Database.loadData.Rows[3]["Time"].ToString();
                iconButton10.Visible = true;
            }
            else
            {
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                iconButton10.Visible = false;
                iconButton11.Visible = false;
                iconButton12.Visible = false;
            }
            if (num > 4)
            {
                textBox15.Visible = true;
                textBox15.Text = Database.loadData.Rows[4][mode].ToString();
                historytime15 = Database.loadData.Rows[4]["Time"].ToString();
                iconButton11.Visible = true;
            }
            else
            {
                textBox15.Visible = false;
                textBox16.Visible = false;
                iconButton11.Visible = false;
                iconButton12.Visible = false;
            }
            if (num > 5)
            {
                textBox16.Visible = true;
                textBox16.Text = Database.loadData.Rows[5][mode].ToString();
                historytime16 = Database.loadData.Rows[5]["Time"].ToString();
                iconButton12.Visible = true;
            }
            else
            {
                textBox16.Visible = false;
                iconButton12.Visible = false;
            }
        }

        private void loadDefaultSuggestion()
        {
            textboxSearch.HintText = "Search " + mode;
            textboxSearch.Text = "";
            textBoxResult.Text = "Searched " + mode;
            labelLanguage.Text = labelLanguage.Text.ToString() + mode;
        }

        private void textboxBookmark_OnValueChanged(object sender, EventArgs e)
        {
            command = "Use sql_invoicing; SELECT * from " + mode + "bookmark " + "where " + mode + " like " + "\"" + textboxBookmark.Text + "%\""+"order by id desc";
            Database.load(command);
            bookmarkRowCount = Database.loadData.Rows.Count;
            bookmarkData = Database.loadData;
            loadSearchSuggestionBookmark();
            resetSuggestionBookmarkColor();
            reseticonButtonSuggestionBookmarkColor();
            loadPageInfo();    
        }
        
        private void textboxSearch_OnValueChanged(object sender, EventArgs e)
        {
            resetSuggestionColor();
            loadSearchSuggestion();
        }

        private void iconButtonSearchHistory_Click(object sender, EventArgs e)
        {
            activateIconButtonSearchHistory();
        }

        private void iconButtonSearchBookmark_Click(object sender, EventArgs e)
        {
            activateIconButtonSearchBookmark();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            activateButtonSearch();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (ktSwitch == true)
            {
                ktSwitch = false;
                pictureBoxFlagLeft.Image = Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = Properties.Resources.united_kingdom;
                labelLanguage.Text = "Vietnamese " + mode;
                language = "vie";
                if (Database.BookandMore == 2)
                    labelLanguage.Text = "Vietnam luminary";
            }
            else
            {
                ktSwitch = true;
                pictureBoxFlagLeft.Image = Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = Properties.Resources.vietnam;
                labelLanguage.Text = "English " + mode;
                language = "eng";
                if (Database.BookandMore == 2)
                    labelLanguage.Text = "World luminary";
            }
            loadSearchSuggestion();
        }

        private void textBoxMeaning_Click(object sender, EventArgs e)
        {
            if (mode!="Idiom")
                System.Diagnostics.Process.Start(textBoxMeaning.Text.ToString());
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = textBox1.Text;
            activateButtonSearch();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = textBox2.Text;
            activateButtonSearch();
        }
    
        private void textBox3_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = textBox3.Text;
            activateButtonSearch();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = textBox4.Text;
            activateButtonSearch();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox6.Text;
            activateIconButtonSearchBookmark();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox7.Text;
            activateIconButtonSearchBookmark();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox8.Text;
            activateIconButtonSearchBookmark();
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox9.Text;
            activateIconButtonSearchBookmark();
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox11.Text;
            activateIconButtonSearchHistory();
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox12.Text;
            activateIconButtonSearchHistory();
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox13.Text;
            activateIconButtonSearchHistory();
        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox14.Text;
            activateIconButtonSearchHistory();
        }

        private void textBox15_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox15.Text;
            activateIconButtonSearchHistory();
        }

        private void textBox16_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox16.Text;
            activateIconButtonSearchHistory();
        }

        #endregion

        #region Bookmark

        private void loadDatabase(string cmd)
        {
            Database.load(cmd);
            for (int i = 0; i < 100000; i++)
                check[i] = true;
        }

        private void loadBookmarkData()
        {
            loadPageInfo();
            if (bookmarkRowCount > 0 + 4 * page)
            {
                textBox6.Visible = true;
                textBox6.Text = bookmarkData.Rows[page * 4][mode].ToString();
                iconButton1.Visible = true;
                if (check[page * 4 + 1] == true)
                    iconButton1.IconColor = Color.FromArgb(238, 26, 74);
                else
                    iconButton1.IconColor = Color.Gainsboro;
            }
            else
            {
                textBox6.Visible = false;
                iconButton1.Visible = false;
            }
            if (bookmarkRowCount > 1 + 4 * page)
            {
                textBox7.Visible = true;
                textBox7.Text = bookmarkData.Rows[page * 4+1][mode].ToString();
                iconButton2.Visible = true;
                if (check[page * 4 + 2] == true)
                    iconButton2.IconColor = Color.FromArgb(238, 26, 74);
                else
                    iconButton2.IconColor = Color.Gainsboro;
            }
            else
            {
                textBox7.Visible = false;
                iconButton2.Visible = false;
            }
            if (bookmarkRowCount > 2 + 4 * page)
            {
                textBox8.Visible = true;
                textBox8.Text = bookmarkData.Rows[page * 4+2][mode].ToString();
                iconButton3.Visible = true;
                if (check[page * 4 + 3] == true)
                    iconButton3.IconColor = Color.FromArgb(238, 26, 74);
                else
                    iconButton3.IconColor = Color.Gainsboro;
            }
            else
            {
                textBox8.Visible = false;
                iconButton3.Visible = false;
            }
            if (bookmarkRowCount > 3 + 4 * page)
            {
                textBox9.Visible = true;
                textBox9.Text = bookmarkData.Rows[page * 4+3][mode].ToString();
                iconButton4.Visible = true;
                if (check[page * 4 + 4] == true)
                    iconButton4.IconColor = Color.FromArgb(238, 26, 74);
                else
                    iconButton4.IconColor = Color.Gainsboro;
            }
            else
            {
                textBox9.Visible = false;
                iconButton4.Visible = false;
            }
        }

        private void loadBookmark()
        {
            command = " SELECT "+mode+" from "+mode+"bookmark where "+mode+" = " + "\"" + textBoxResult.Text.ToString() + "\""; //+ "and languages= " + "'" + hint + "'";
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
            if ((page + 1) * 4 < bookmarkRowCount)
                max = ((page + 1) * 4).ToString();
            else max = bookmarkRowCount.ToString();
            if (bookmarkRowCount == 0)
                pageInfo.Visible = false;
            else
                pageInfo.Visible = true;
            pageInfo.Text = (page * 4 + 1).ToString() + " - " + max + " / " + bookmarkRowCount.ToString() + " " + mode;
        }

        private void activateReloadButton()
        {
            page = 0;
            command = "select * from " + mode + "bookmark order by id DESC";
            loadDatabase(command);
            bookmarkRowCount = Database.loadData.Rows.Count;
            bookmarkData = Database.loadData;
            loadBookmarkData();
        }

        private void iconBookmark_Click(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (ktBookmark == false)
            {
                ktBookmark = true;
                iconBookmark.IconColor = RGBColors.color7;
                if (mode=="Book")
                    Database.insertBookBookmark(textBoxResult.Text, textBoxMeaning.Text, time);
                if (mode=="Idiom")
                    Database.insertIdiomBookmark(textBoxResult.Text, textBoxMeaning.Text, time);
                if (mode == "Luminary")
                    Database.insertLuminaryBookmark(textBoxResult.Text, textBoxMeaning.Text, time);
                command = "select * from "+mode+"bookmark order by id DESC";
                loadDatabase(command);
                loadBookmarkData();
            }
            else
            {
                ktBookmark = false;
                iconBookmark.IconColor = Color.Gainsboro;
                command = "delete from "+mode+"bookmark where " + mode + "=" + "'" + textBoxResult.Text + "'";//+ "AND languages=" + "'" + hint + "'";
                Database.deleteBookmark(command);
            }
            activateReloadButton();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (iconButton1.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from "+mode+"bookmark where "+mode+" "+" =" + "\"" + textBox6.Text + "\"";
                Database.deleteBookmark(command);
                iconButton1.IconColor = Color.Gainsboro;
                check[page * 4 + 1] = false;
            }
            else
            {
                iconButton1.IconColor = Color.FromArgb(238, 26, 74);
                if (mode=="Book")
                    Database.insertBookBookmark(textBox6.Text, link1, time);
                if (mode=="Idiom")
                    Database.insertIdiomBookmark(textBox6.Text, link1, time);
                if (mode == "Luminary")
                    Database.insertLuminaryBookmark(textBox6.Text, link1, time);
                check[page * 4 + 1] = true;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (iconButton2.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from "+mode+"bookmark where book =" + "\"" + textBox7.Text + "\"";
                Database.deleteBookmark(command);
                iconButton2.IconColor = Color.Gainsboro;
                check[page * 13 + 2] = false;
            }
            else
            {
                iconButton2.IconColor = Color.FromArgb(238, 26, 74);
                if (mode == "Book")
                    Database.insertBookBookmark(textBox7.Text, link2, time);
                if (mode == "Idiom")
                    Database.insertIdiomBookmark(textBox7.Text, link2, time);
                if (mode == "Luminary")
                    Database.insertLuminaryBookmark(textBox7.Text, link2, time);
                check[page * 13 + 2] = true;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (iconButton3.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from "+mode+"bookmark where book =" + "\"" + textBox8.Text + "\"";
                Database.deleteBookmark(command);
                iconButton3.IconColor = Color.Gainsboro;
                check[page * 4 + 3] = false;
            }
            else
            {
                iconButton3.IconColor = Color.FromArgb(238, 26, 74);
                if (mode == "Book")
                    Database.insertBookBookmark(textBox8.Text, link3, time);
                if (mode == "Idiom")
                    Database.insertIdiomBookmark(textBox8.Text, link3, time);
                if (mode == "Luminary")
                    Database.insertLuminaryBookmark(textBox8.Text, link3, time);
                check[page * 4 + 3] = true;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
            if (iconButton4.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from "+mode+"bookmark where book =" + "\"" + textBox9.Text + "\"";
                Database.deleteBookmark(command);
                iconButton4.IconColor = Color.Gainsboro;
                check[page * 4 + 4] = false;
            }
            else
            {
                iconButton4.IconColor = Color.FromArgb(238, 26, 74);
                if (mode == "Book")
                    Database.insertBookBookmark(textBox9.Text, link4, time);
                if (mode == "Idiom")
                    Database.insertIdiomBookmark(textBox9.Text, link4, time);
                if (mode == "Luminary")
                    Database.insertLuminaryBookmark(textBox9.Text, link4, time);
                check[page * 4 + 4] = true;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if ((page + 1) * 4 < bookmarkRowCount)
            {
                page = page + 1;
                loadBookmarkData();
            }
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page = page - 1;
                loadBookmarkData();
            }
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            activateReloadButton();
        }

        private void iconButtonExcel_Click(object sender, EventArgs e)
        {
            command = "select * from "+mode+"bookmark order by id DESC";
            loadDatabase(command);
            DataView view = new DataView(Database.loadData);
            DataTable selected = view.ToTable(false, "book", "link", "savedtime");
            var folderBrowserDialog1 = new FolderBrowserDialog();
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Excel.ExcelUtlity obj = new Excel.ExcelUtlity();
                string folderName = folderBrowserDialog1.SelectedPath;
                obj.WriteDataTableToExcel(selected, "Saved Book List", folderName + "SavedBookList.xlsx", "SavedBookList");
                MessageBox.Show("File was created");
            }
        }

        #endregion

        #region History

        private void textboxHistory_OnValueChanged(object sender, EventArgs e)
        {
            resetSuggestionHistoryColor();
            loadSearchSuggestionHistory();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            command = "delete from "+mode+"history where " + mode + " " + " =" + "\"" + textBox11.Text + "\"";
            Database.deleteHistory(command);
            resetSuggestionHistoryColor();
            loadSearchSuggestionHistory();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            command = "delete from "+mode+"history where " + mode + " " + " =" + "\"" + textBox12.Text + "\"";
            Database.deleteHistory(command);
            resetSuggestionHistoryColor();
            loadSearchSuggestionHistory();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            command = "delete from "+mode+"history where " + mode + " " + " =" + "\"" + textBox13.Text + "\"";
            Database.deleteHistory(command);
            resetSuggestionHistoryColor();
            loadSearchSuggestionHistory();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            command = "delete from "+mode+"history where " + mode + " " + " =" + "\"" + textBox14.Text + "\"";
            Database.deleteHistory(command);
            resetSuggestionHistoryColor();
            loadSearchSuggestionHistory();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            command = "delete from "+mode+"history where " + mode + " " + " =" + "\"" + textBox15.Text + "\"";
            Database.deleteHistory(command);
            resetSuggestionHistoryColor();
            loadSearchSuggestionHistory();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            command = "delete from "+mode+"history where " + mode + " " + " =" + "\"" + textBox16.Text + "\"";
            Database.deleteHistory(command);
            resetSuggestionHistoryColor();
            loadSearchSuggestionHistory();
        }


        #endregion

        #region Text UI

        private void Idiom_Load(object sender, EventArgs e)
        {
            textBox1.Cursor = Cursors.Hand;
            textBox1.GotFocus += textBox_GotFocus;
            textBox2.Cursor = Cursors.Hand;
            textBox2.GotFocus += textBox_GotFocus;
            textBox3.Cursor = Cursors.Hand;
            textBox3.GotFocus += textBox_GotFocus;
            textBox4.Cursor = Cursors.Hand;
            textBox4.GotFocus += textBox_GotFocus;
            textBox6.Cursor = Cursors.Hand;
            textBox6.GotFocus += textBox_GotFocus;
            textBox7.Cursor = Cursors.Hand;
            textBox7.GotFocus += textBox_GotFocus;
            textBox8.Cursor = Cursors.Hand;
            textBox8.GotFocus += textBox_GotFocus;
            textBox9.Cursor = Cursors.Hand;
            textBox9.GotFocus += textBox_GotFocus;
            textBox11.Cursor = Cursors.Hand;
            textBox11.GotFocus += textBox_GotFocus;
            textBox12.Cursor = Cursors.Hand;
            textBox12.GotFocus += textBox_GotFocus;
            textBox13.Cursor = Cursors.Hand;
            textBox13.GotFocus += textBox_GotFocus;
            textBox14.Cursor = Cursors.Hand;
            textBox14.GotFocus += textBox_GotFocus;
            textBox15.Cursor = Cursors.Hand;
            textBox15.GotFocus += textBox_GotFocus;
            textBox16.Cursor = Cursors.Hand;
            textBox16.GotFocus += textBox_GotFocus;
            textBoxMeaning.Cursor = Cursors.Hand;
            textBoxMeaning.GotFocus += textBox_GotFocus;
        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
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
            toolTip1.SetToolTip(textBox11, historytime11);
        }

        private void textBox11_MouseLeave(object sender, EventArgs e)
        {
            textBox11.ForeColor = Color.Gainsboro;
        }

        private void textBox12_MouseHover(object sender, EventArgs e)
        {
            textBox12.ForeColor = Color.FromArgb(242, 98, 121);
            toolTip1.SetToolTip(textBox12, historytime12);
        }

        private void textBox12_MouseLeave(object sender, EventArgs e)
        {
            textBox12.ForeColor = Color.Gainsboro;
        }

        private void textBox13_MouseHover(object sender, EventArgs e)
        {
            textBox13.ForeColor = Color.FromArgb(242, 98, 121);
            toolTip1.SetToolTip(textBox13, historytime13);
        }

        private void textBox13_MouseLeave(object sender, EventArgs e)
        {
            textBox13.ForeColor = Color.Gainsboro;
        }

        private void textBox14_MouseHover(object sender, EventArgs e)
        {
            textBox14.ForeColor = Color.FromArgb(242, 98, 121);
            toolTip1.SetToolTip(textBox14, historytime14);
        }

        private void textBox14_MouseLeave(object sender, EventArgs e)
        {
            textBox14.ForeColor = Color.Gainsboro;
        }

        private void textBox15_MouseHover(object sender, EventArgs e)
        {
            textBox15.ForeColor = Color.FromArgb(242, 98, 121);
            toolTip1.SetToolTip(textBox15, historytime15);
        }

        private void textBox15_MouseLeave(object sender, EventArgs e)
        {
            textBox15.ForeColor = Color.Gainsboro;
        }

        private void textBox16_MouseHover(object sender, EventArgs e)
        {
            textBox16.ForeColor = Color.FromArgb(242, 98, 121);
            toolTip1.SetToolTip(textBox16, historytime16);
        }

        private void textBox16_MouseLeave(object sender, EventArgs e)
        {
            textBox16.ForeColor = Color.Gainsboro;
        }

        private void textBoxMeaning_MouseHover(object sender, EventArgs e)
        {
            textBoxMeaning.ForeColor = Color.FromArgb(24, 161, 251);
        }

        private void textBoxMeaning_MouseLeave(object sender, EventArgs e)
        {
            textBoxMeaning.ForeColor = Color.Gainsboro;
        }

        #endregion

        public Idiom()
        {
            InitializeComponent();
            if (Database.BookandMore == 0)
            {
                mode = "Book";
            }
            if (Database.BookandMore == 1)
            {
                mode = "Idiom";
            }
            if (Database.BookandMore == 2)
            {
                mode = "Luminary";
                labelLanguage.Text = "Vietnam ";
            }
            loadDefaultSuggestion();
            suggestionRowCount = Database.loadData.Rows.Count;
            
            command = "Use sql_invoicing; SELECT * from " + mode + "bookmark " + "where " + mode + " like " + "\"" + textboxBookmark.Text + "%\""+"order by id desc";
            Database.load(command);
            bookmarkRowCount = Database.loadData.Rows.Count;
            bookmarkData = Database.loadData;
            loadSearchSuggestionBookmark();
            loadPageInfo();

            loadSearchSuggestionHistory();
            historyRowCount = Database.loadData.Rows.Count;
            for (int i = 0; i < 100000; i++)
                check[i] = true;
        }
    }
}
