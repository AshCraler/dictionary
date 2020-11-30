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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void iconButtonHistory_Click(object sender, EventArgs e)
        {
            string message = "Do you want to clear history";
            string title = "Clear History";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Database.deleteHistory("delete from historysearch");
                MessageBox.Show("Your history was cleared");
            }
        }

        private void iconButtonBookmark_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete all bookmarks";
            string title = "Delete Bookmarks";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Database.load("Select word from bookmark");
                for (int i = 0; i < Database.loadData.Rows.Count; i++)
                {
                    string remove = Database.loadData.Rows[i]["word"].ToString();
                    Database.updateHistory("update historysearch set bookmark = " + "'" + "No" + "'" + " where Word = " +"'"+ remove+"'");
                }
                Database.deleteBookmark("delete from bookmark");
                MessageBox.Show("Your bookmarks were deleted");
            }
        }
    }
}
