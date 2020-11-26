using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;

namespace Dictionary_user
{
    
    public partial class Feedback : Form
    {
        public Connection_BUS objFeedBack = new Connection_BUS();
        private DictionaryDTO.FeedBack fb = new DictionaryDTO.FeedBack();
        

        public Feedback()
        {
            InitializeComponent();
        }

        
        private void buttonSendFeedBack_Click(object sender, EventArgs e)
        {
            fb.email = textBoxEmail.Text;
            fb.fullName = textBoxName.Text;
            fb.phoneNumber = textBoxPhoneNumber.Text;
            fb.content = textBoxContent.Text;

            if (objFeedBack.feedBack(fb))
                MessageBox.Show("Success");
        }

        
    }
}
