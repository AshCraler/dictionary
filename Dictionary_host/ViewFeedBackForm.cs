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
    public partial class ViewFeedBackForm : Form
    {
        private DictionaryDTO.FeedBackDTO currentFeedBack;
        private BusinessLogicTier.FeedBack_BUS fbManager = new BusinessLogicTier.FeedBack_BUS();

        public ViewFeedBackForm()
        {
            InitializeComponent();
        }

        public ViewFeedBackForm(DictionaryDTO.FeedBackDTO f)
        {
            InitializeComponent();
            currentFeedBack = f;

            textBoxTitle.Text = f.title;
            labelName2.Text = f.fullName;
            labelEmail2.Text = f.email;
            labelPhoneNumber2.Text = f.phoneNumber;
            labelTime.Text = f.time.ToString();
            textBoxContent.Text = f.content;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteFeedBack_Click(object sender, EventArgs e)
        {
            fbManager.removeFeedBack(currentFeedBack);

            this.Close();
        }
    }
}
