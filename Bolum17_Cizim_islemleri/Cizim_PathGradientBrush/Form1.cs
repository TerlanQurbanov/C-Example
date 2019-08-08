using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Cizim_PathGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCiz_Click(object sender, EventArgs e)
        {           
            Pen myPen = new Pen(Color.Black, 2);
            Graphics formGraphics = null;
            formGraphics = this.CreateGraphics();

            formGraphics.SmoothingMode = SmoothingMode.AntiAlias;

            Point[] points = new Point[] { new Point(10, 10), 
                                  new Point(310, 10), 
                                  new Point(310, 90), 
                                  new Point(10, 90) };

            PathGradientBrush PGBrush = new PathGradientBrush(points);

            formGraphics.FillRectangle(PGBrush, new Rectangle
                    (10, 10, 300, 80));
            formGraphics.DrawRectangle(myPen, new Rectangle
                    (10, 10, 300, 80));
        }
    }
}
