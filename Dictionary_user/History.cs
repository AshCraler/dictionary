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
            if (Database.acction=="showHistoryList")
                Database.load("SELECT Word,Meaning,Translate,TimeSearch AS Date ,Bookmark from historysearch ORDER BY id DESC");
            bunifuCustomDataGrid1.DefaultCellStyle.Format = "dd/MM/yyyy";
            bunifuCustomDataGrid1.DataSource = Database.loadData;
        }
    }
}
