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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void labeLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AshCraler/dictionary");
        }

        private void labeLink_MouseHover(object sender, EventArgs e)
        {
            labeLink.ForeColor = Color.FromArgb(24, 161, 251);
        }

        private void labeLink_MouseLeave(object sender, EventArgs e)
        {
            labeLink.ForeColor = Color.Gainsboro;
        }
    }
}
