using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Image_Tag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        Image image;
        string dosya;
        private void btnSec_Click(object sender, EventArgs e)
        {
            DialogResult buton = openFileDialog1.ShowDialog();
            if (buton == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName);
                dosya = openFileDialog1.FileName;
                bmp = (Bitmap)image;
                pictureBox1.Image = bmp;
                if (image.Tag!=null)
                    textBox1.Text = image.Tag.ToString();
            }
        }

        private void btnTagYaz_Click(object sender, EventArgs e)
        {
            using (Image image = Image.FromFile(dosya))
            {
                image.Tag = textBox1.Text;                
            }
        }
    }
}
