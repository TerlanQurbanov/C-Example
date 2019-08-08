using System;
using System.Drawing;
using System.Windows.Forms;
namespace DrawString_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCiz_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            string drawString = "Örnek yazı";
            Font drawFont = new Font("Comic Sans MS", 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            StringFormat drawFormat = new StringFormat
                (StringFormatFlags.DirectionVertical);

            formGraphics.DrawString(drawString, drawFont,
                drawBrush, 60, 10, drawFormat);

            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();

        }
    }
}
