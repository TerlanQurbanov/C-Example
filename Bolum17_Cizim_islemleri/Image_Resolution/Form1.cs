using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Resolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            DialogResult buton = openFileDialog1.ShowDialog();
            if (buton == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
                lblGenislikYukseklik.Text = "Genişlik : " + image.Width + " Yükseklik: " + image.Height;
                lblCozunurluk.Text = "Dikey Çözünürlük: " + image.VerticalResolution + " Yatay Çözünürlük: " + image.HorizontalResolution;
            }
        }
    }
}
