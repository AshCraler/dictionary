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
    public partial class History : Form
    {
        private string command;
        private string word;
        private string translate;
        
        private void loadDatabase()
        {
            if (Database.acction == "searchHistory")
                command = "select Word, Meaning, Translate,TimeSearch,Bookmark from historysearch Where word = " + "\"" + Database.textboxSearchText.ToString() + "\"" + " or meaning = " + "\"" + Database.textboxSearchText.ToString() + "\"";
            if (Database.acction == "showHistoryList")
                command = "SELECT Word,Meaning,Translate,TimeSearch AS Date ,Bookmark from historysearch ORDER BY id DESC";
            Database.load(command);
        }
       
        public History()
        {
            InitializeComponent();
            loadDatabase();
            bunifuCustomDataGrid1.DefaultCellStyle.Format = "dd/MM/yyyy";
            bunifuCustomDataGrid1.DataSource = Database.loadData;
        }
        private void bunifuCustomDataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in bunifuCustomDataGrid1.SelectedRows)
            {
                word = row.Cells[0].Value.ToString();
                translate = row.Cells[2].Value.ToString();
            }
        }
        private void bunifuCustomDataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                Database.acction = "clickFromBookmark";
                Database.word = word;
                if (translate == "Eng-Vie")
                    Database.setLanguages = false;
                else Database.setLanguages = true;
                this.Close();
            }
        }
    }
}
