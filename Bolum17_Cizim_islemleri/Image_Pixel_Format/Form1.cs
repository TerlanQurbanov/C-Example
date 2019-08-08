using System;
using System.Drawing;
using System.Windows.Forms;
namespace Image_Pixel_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        Image image;
        private void btnSec_Click(object sender, EventArgs e)
        {
            DialogResult buton = openFileDialog1.ShowDialog();
            if (buton == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName);
                bmp = (Bitmap)image;
                pictureBox1.Image = bmp;
                label1.Text = image.PixelFormat.ToString();
            }
        }
        private void btnislemYap_Click(object sender, EventArgs e)
        {
            int x, y;            
            for (x = 0; x < bmp.Width; x++)
            {
                for (y = 0; y < bmp.Height; y++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R,0, 0);
                    bmp.SetPixel(x, y, newColor);
                }
            }            
            pictureBox2.Image = bmp;            
            label2.Text = bmp.PixelFormat.ToString();
        }
    }
}
