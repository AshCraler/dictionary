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
    public partial class Bookmark : Form
    {
        private int page = 0;
        private void loadWord()
        {
            if (Database.loadData.Rows.Count>0+13*page)
                labelWord1.Text = Database.loadData.Rows[page*13]["Word"].ToString();
            if (Database.loadData.Rows.Count > 1+13*page)
                labelWord2.Text = Database.loadData.Rows[page*13 + 1]["Word"].ToString();
            if (Database.loadData.Rows.Count > 2+13*page)
                labelWord3.Text = Database.loadData.Rows[page*13 + 2]["Word"].ToString();
            if (Database.loadData.Rows.Count > 3+13*page)
                labelWord4.Text = Database.loadData.Rows[page*13 + 3]["Word"].ToString();
            if (Database.loadData.Rows.Count > 4+13*page)
                labelWord5.Text = Database.loadData.Rows[page*13 + 4]["Word"].ToString();
            if (Database.loadData.Rows.Count > 5+13*page)
                labelWord6.Text = Database.loadData.Rows[page*13 + 5]["Word"].ToString();
            if (Database.loadData.Rows.Count > 6+13*page)
                labelWord7.Text = Database.loadData.Rows[page*13 + 6]["Word"].ToString();
            if (Database.loadData.Rows.Count > 7+13*page)
                labelWord8.Text = Database.loadData.Rows[page*13 + 7]["Word"].ToString();
            if (Database.loadData.Rows.Count > 8+13*page)
                labelWord9.Text = Database.loadData.Rows[page*13 + 8]["Word"].ToString();
            if (Database.loadData.Rows.Count > 9+13*page)
                labelWord10.Text = Database.loadData.Rows[page*13 + 9]["Word"].ToString();
            if (Database.loadData.Rows.Count > 10+13*page)
                labelWord11.Text = Database.loadData.Rows[page*13 + 10]["Word"].ToString();
            if (Database.loadData.Rows.Count > 11+13*page)
                labelWord12.Text = Database.loadData.Rows[page*13 + 11]["Word"].ToString();
            if (Database.loadData.Rows.Count > 12+13*page)
                labelWord13.Text = Database.loadData.Rows[page*13 + 12]["Word"].ToString();
        }
        private void loadMeaning()
        {
            if (Database.loadData.Rows.Count > 0 + 13 * page)
                labelMeaning1.Text = Database.loadData.Rows[page * 13]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 1 + 13 * page)
                labelMeaning2.Text = Database.loadData.Rows[page * 13 + 1]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 2 + 13 * page)
                labelMeaning3.Text = Database.loadData.Rows[page * 13 + 2]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 3 + 13 * page)
                labelMeaning4.Text = Database.loadData.Rows[page * 13 + 3]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 4 + 13 * page)
                labelMeaning5.Text = Database.loadData.Rows[page * 13 + 4]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 5 + 13 * page)
                labelMeaning6.Text = Database.loadData.Rows[page * 13 + 5]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 6 + 13 * page)
                labelMeaning7.Text = Database.loadData.Rows[page * 13 + 6]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 7 + 13 * page)
                labelMeaning8.Text = Database.loadData.Rows[page * 13 + 7]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 8 + 13 * page)
                labelMeaning9.Text = Database.loadData.Rows[page * 13 + 8]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 9 + 13 * page)
                labelMeaning10.Text = Database.loadData.Rows[page * 13 + 9]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 10 + 13 * page)
                labelMeaning11.Text = Database.loadData.Rows[page * 13 + 10]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 11 + 13 * page)
                labelMeaning12.Text = Database.loadData.Rows[page * 13 + 11]["meaning"].ToString();
            if (Database.loadData.Rows.Count > 12 + 13 * page)
                labelMeaning13.Text = Database.loadData.Rows[page * 13 + 12]["meaning"].ToString();
        }
        public Bookmark()
        {
            InitializeComponent();
            if (Database.acction == "showBookmarkList")
                Database.load("select word, meaning from bookmark order by id DESC");
            loadWord();
            loadMeaning();
        }
    }
}
