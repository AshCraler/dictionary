using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DictionaryDTO;
using DataAccessTier;
using BusinessLogicTier;

namespace Dictionary_host
{
    public partial class FeedBackForm : Form
    {
        FeedBack_BUS fbManager = new FeedBack_BUS();

        public FeedBackForm()
        {
            InitializeComponent();
            loadFeedBack();
        }

        private void loadFeedBack()
        {
            feedBackGridView.DataSource = fbManager.allFeedBacks();
            feedBackGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void openViewFBForm(ViewFeedBackForm f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnDeleteFeedBack_Click(object sender, EventArgs e)
        {
            int id = int.Parse(feedBackGridView.CurrentRow.Cells[1].Value.ToString());
            DateTime time = (System.DateTime)feedBackGridView.CurrentRow.Cells[2].Value;
            string title = feedBackGridView.CurrentRow.Cells[3].Value.ToString();
            string name = feedBackGridView.CurrentRow.Cells[4].Value.ToString();
            string email = feedBackGridView.CurrentRow.Cells[5].Value.ToString();
            string num = feedBackGridView.CurrentRow.Cells[6].Value.ToString();
            string content = feedBackGridView.CurrentRow.Cells[7].Value.ToString();
            

            DictionaryDTO.FeedBackDTO fb = new FeedBackDTO(id, time, title, email, name, num, content);

            fbManager.removeFeedBack(fb);

            loadFeedBack();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(feedBackGridView.CurrentRow.Cells[1].Value.ToString());
            DateTime time = (System.DateTime)feedBackGridView.CurrentRow.Cells[2].Value;
            string title = feedBackGridView.CurrentRow.Cells[3].Value.ToString();
            string name = feedBackGridView.CurrentRow.Cells[4].Value.ToString();
            string email = feedBackGridView.CurrentRow.Cells[5].Value.ToString();
            string num = feedBackGridView.CurrentRow.Cells[6].Value.ToString();
            string content = feedBackGridView.CurrentRow.Cells[7].Value.ToString();

            DictionaryDTO.FeedBackDTO fb = new FeedBackDTO(id, time, title, email, name, num, content);

           
            openViewFBForm(new ViewFeedBackForm(fb));
        }


        private void FeedBackForm_Paint(object sender, PaintEventArgs e)
        {
            loadFeedBack();
        }
    }
}
