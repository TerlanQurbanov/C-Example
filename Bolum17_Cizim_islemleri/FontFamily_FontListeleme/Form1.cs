using System;
using System.Drawing;
using System.Windows.Forms;
namespace FontFamily_FontListeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily fonts in FontFamily.Families)
            {
                listBox1.Items.Add(fonts.Name);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(SystemColors.Control);
            string drawString = "Örnek yazı";
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            Font drawFont = new Font(listBox1.Text, 20,
                FontStyle.Bold | FontStyle.Italic);

            formGraphics.DrawString(drawString,
                drawFont, drawBrush, 20, 30);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
