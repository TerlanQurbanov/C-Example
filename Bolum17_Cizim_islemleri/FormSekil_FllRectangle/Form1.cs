using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FormSekil_FllRectangle
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
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            //Brush fillBrush = Brushes.Gray;
            HatchBrush hBrush = new HatchBrush(HatchStyle.DashedHorizontal,
                Color.Gray, Color.GhostWhite);

            formGraphics.SmoothingMode = SmoothingMode.AntiAlias;

            //formGraphics.FillRectangle(fillBrush, new Rectangle
            //    (10, 10, 250, 80));
            formGraphics.FillRectangle(hBrush, new Rectangle
                (10, 10, 250, 80));
            formGraphics.DrawRectangle(myPen, new Rectangle
                (10, 10, 250, 80));

            myPen.Dispose();
            formGraphics.Dispose();
        }
    }
}
