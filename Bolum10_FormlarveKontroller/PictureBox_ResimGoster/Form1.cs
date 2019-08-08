using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace PictureBox_ResimGoster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "dosya seç";
            openFileDialog1.Filter = "jpeg dosyaları (*.jpeg) |*.jpg|bmp dosyaları (*.bmp)|*.bmp|gif dosyaları (*.gif)|*.gif";
            openFileDialog1.Title = "Lütfen Bir Resim Dosyası Seçin";
            openFileDialog1.InitialDirectory =@"C:\Users\user\Pictures";
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = new Bitmap(openFileDialog1.OpenFile());
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(textBox1.Text);
        }
    }
}
