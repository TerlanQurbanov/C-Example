using System;
using System.Drawing;
using System.Windows.Forms;
namespace Form_Draw_Yazı
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

            formGraphics.DrawString(drawString,
                drawFont, drawBrush, 50, 30);

            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
