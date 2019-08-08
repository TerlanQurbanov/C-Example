using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Form_Sekiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCiz_Click(object sender, EventArgs e)
        {
            int x, y;
            x = 10;
            y = 10;
            Pen myPen = new Pen(Color.Black, 2);
            Graphics formGraphics = null;
            formGraphics = this.CreateGraphics();
            formGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Times New Roman", 12,
                FontStyle.Bold);

            formGraphics.DrawRectangle(myPen, new Rectangle
                (x, y, 120, 60));
            formGraphics.DrawString("Rectangle", drawFont,
                drawBrush, x + 30, y + 60);

            formGraphics.DrawArc(myPen, new Rectangle
                (x + 150, y, 100, 120), 180, 180);
            formGraphics.DrawString("Arc", drawFont, drawBrush,
                x + 180, y + 60);

            formGraphics.DrawLine(myPen, new Point(x + 300, y + 40),
                new Point(x + 400, y + 40));
            formGraphics.DrawString("Line", drawFont, drawBrush,
                x + 330, y + 60);

            formGraphics.DrawCurve(myPen, new Point[] 
                { new Point(x, y + 120), new Point(x + 60, y + 120), 
                new Point(x + 60, y + 150), new Point(x + 90, y + 150) });
            formGraphics.DrawString("Curve", drawFont, drawBrush,
                x + 30, y + 160);

            formGraphics.DrawClosedCurve(myPen, new Point[] 
                { new Point(x+150, y + 120), new Point(x + 210, y + 120), 
                new Point(x + 210, y + 150), new Point(x + 240, y + 150) });
            formGraphics.DrawString("Closed Curve", drawFont, drawBrush,
                x + 180, y + 160);

            formGraphics.DrawBezier(myPen, new Point(300, y + 140),
                new Point(325, y + 120), new Point(375, y + 160),
                new Point(x + 400, y + 140));
            formGraphics.DrawString("Bezier", drawFont, drawBrush,
                x + 330, y + 160);


            formGraphics.DrawPie(myPen, x, y + 220, 80, 80, 180, 180);
            formGraphics.DrawString("Pie", drawFont, drawBrush,
                x + 30, y + 270);

            formGraphics.DrawPolygon(myPen, new Point[] 
                { new Point(x + 160, y+210), new Point(x + 230, y+210), 
                new Point(x + 160, y + 260), new Point(x + 230, y + 260) });
            formGraphics.DrawString("Polygon", drawFont, drawBrush,
                x + 180, y + 270);

            formGraphics.DrawEllipse(myPen, x + 300, y + 190, 80, 80);
            formGraphics.DrawString("Ellipse", drawFont, drawBrush,
                x + 330, y + 270);
            

            myPen.Dispose();
            formGraphics.Dispose();
        }
    }
}
