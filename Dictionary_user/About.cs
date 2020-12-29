using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            labeLink.Cursor = Cursors.Hand;
        }

        private void labeLink_MouseLeave(object sender, EventArgs e)
        {
            labeLink.ForeColor = Color.Gainsboro;
        }

        private void iconButtonFeedback_Click(object sender, EventArgs e)
        {
            string connectionStr= @"Data Source=ashcraler.database.windows.net;Initial Catalog=Dictionary;Persist Security Info=True;User ID=ashcraler;Password=admin123$%^";
            SqlConnection conn;

            try
            {
                conn = new SqlConnection(connectionStr);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using(SqlCommand cmd = new SqlCommand("INSERT INTO tbFeedBack VALUES (@Time, @Title, @FullName, @Email, @PhoneNumber, @Content)", conn))
                {
                    cmd.Parameters.Add("@Time", SqlDbType.SmallDateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = bunifuMaterialTextbox1.Text;
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = bunifuMaterialTextbox2.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = bunifuMaterialTextbox3.Text;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = bunifuMaterialTextbox4.Text;
                    cmd.Parameters.Add("@Content", SqlDbType.NText).Value = richTextBox1.Text;

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
            MessageBox.Show("Your feedback was sent, thank you soo much ^^ ");
        }
    }
}
