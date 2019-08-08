using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Cizim_LinearGradientBrush
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

            LinearGradientBrush LGBrush = new LinearGradientBrush
                (ClientRectangle, Color.White, Color.Gray,
                LinearGradientMode.Horizontal);

            formGraphics.FillRectangle(LGBrush, new Rectangle
                (x, y, 300, 80));
            formGraphics.DrawRectangle(myPen, new Rectangle
                (x, y, 300, 80));

            LGBrush.SetSigmaBellShape(0.5f);
            formGraphics.FillRectangle(LGBrush, new Rectangle
                (x, y + 100, 300, 80));
            formGraphics.DrawRectangle(myPen, new Rectangle
                (x, y + 100, 300, 80));

            LGBrush.SetBlendTriangularShape(1);
            formGraphics.FillRectangle(LGBrush, new Rectangle
                (x, y + 200, 300, 80));
            formGraphics.DrawRectangle(myPen, new Rectangle
                (x, y + 200, 300, 80));

            myPen.Dispose();
            formGraphics.Dispose();

        }
    }
}
