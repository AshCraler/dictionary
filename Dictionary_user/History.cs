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
        public History()
        {
            InitializeComponent();
        }

        private void Search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void History_Shown(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Rows.Add(
                new object[]
                {
                    "word1",
                    "meaning",
                    "22/11/2020"
                }
                );
        }
    }
}
