using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MyCheckBox : UserControl
    {
        public MyCheckBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            Rectangle rc = new Rectangle(new Point(0, 0), new Size(150, 150));
            
            g.DrawRectangle(Pens.White, rc);
            
        }
    }
}
