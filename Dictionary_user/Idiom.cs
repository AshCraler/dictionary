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
        public Idiom()
        {
            InitializeComponent();
         //   Database.loadLabel();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (ktSwitch == true)
            {
                ktSwitch = false;
                pictureBoxFlagLeft.Image = Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = Properties.Resources.united_kingdom;
                labelLanguage.Text = "Vietnamese idiom";
            }
            else
            {
                ktSwitch = true;
                pictureBoxFlagLeft.Image = Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = Properties.Resources.vietnam;
                labelLanguage.Text = "English idiom";
            }
        }       
    }
}
