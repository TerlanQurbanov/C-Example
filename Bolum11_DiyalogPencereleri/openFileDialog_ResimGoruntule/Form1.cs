using System;
using System.Drawing;
using System.Windows.Forms;

namespace openFileDialog_ResimGoruntule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = new Bitmap(openFileDialog1.OpenFile()); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "dosya seç";
            openFileDialog1.Filter = "jpeg dosyaları (*.jpeg)|*.jpg|bmp dosyaları (*.bmp)|*.bmp|gif dosyaları(*.gif)|*.gif";
            openFileDialog1.Title = "Lütfen Bir Resim Dosyası Seçin";
            openFileDialog1.InitialDirectory = "E:\\arka_plan";
        }
    }
}
