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
            //passwordTextBox.isPassword = true;
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(accountTextBox.Text == "admin" && passwordTextBox.Text == "123456")
            {
                this.Hide();
                Dictionary_host.Admin adminForm = new Dictionary_host.Admin();
                adminForm.Show();
            }
        }
    }
}
