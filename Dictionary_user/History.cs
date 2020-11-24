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
        private void History_Shown(object sender, EventArgs e)
        {
           Database.load("SELECT Anh,Viet,English,VieMeaning from mytable");
           bunifuCustomDataGrid1.DataSource = Database.loadData.Tables[0];
        }
    }
}
