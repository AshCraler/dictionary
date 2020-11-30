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
using DictionaryDTO;

namespace Dictionary_user
{
    public partial class History : Form
    {
        private VN_EN_History_BUS objVnHistory = new VN_EN_History_BUS();
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
            /*bunifuCustomDataGrid1.Rows.Add(
                new object[]
                {
                    "word1",
                    "meaning",
                    "22/11/2020"
                }
                );*/

            foreach(VN_EN_Word w in objVnHistory.getHistory().data)
            {
                bunifuCustomDataGrid1.Rows.Add(
                    new object[]
                    {
                        w.VNKey,
                        w.WordType,
                        w.Means,
                        w.Example
                    }
                    );
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4) //
            {
                if(objVnHistory.deleteSpecificItem(e.RowIndex))
                    bunifuCustomDataGrid1.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
