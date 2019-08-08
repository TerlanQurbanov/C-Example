using System;
using System.Drawing;
using System.Windows.Forms;
namespace SekilveYazı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCiz_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = CreateGraphics();
            Font drawFont = new Font("Arial", 20);
            SolidBrush drawBrush = new SolidBrush
                (System.Drawing.Color.Black);
            StringFormat drawFormat = new StringFormat
                (StringFormatFlags.LineLimit);

            Rectangle r = new Rectangle(new Point(10, 10),
                new Size(250, 70));
            formGraphics.DrawRectangle(Pens.Black, r);

            formGraphics.DrawString("Birinci Satır" + "\n" +
                "İkinci Satır", drawFont, drawBrush, (Rectangle)r,
                drawFormat);

            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
