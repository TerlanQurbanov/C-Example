using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace saveFileDialog_ResimKaydet
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

            saveFileDialog1.FileName = "dosya seç";
            saveFileDialog1.Filter = "jpeg dosyaları (*.jpeg)|*.jpg|bmp dosyaları (*.bmp)|*.bmp|gif dosyaları(*.gif)|*.gif|İkon dosyaları (*.ico)|*.ico|png dosyaları (*.png)|*.png|tiff dosyaları(*.tiff)|*.tiff"; 
            saveFileDialog1.Title = "Kaydetme Penceresi";
            saveFileDialog1.InitialDirectory = "E:\\arka_plan";
            saveFileDialog1.DefaultExt = "jpeg";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FileName.Substring
                    (saveFileDialog1.FileName.Length - 3, 3))
                {
                    case "bmp":
                        pictureBox1.Image.Save
                           (saveFileDialog1.FileName, ImageFormat.Bmp);
                        break;
                    case "gif":
                        pictureBox1.Image.Save
                           (saveFileDialog1.FileName, ImageFormat.Gif);
                        break;
                    case "jpeg":
                        pictureBox1.Image.Save
                           (saveFileDialog1.FileName, ImageFormat.Jpeg);
                        break;
                    case "png":
                        pictureBox1.Image.Save
                           (saveFileDialog1.FileName, ImageFormat.Png);
                        break;
                    case "ico":
                        pictureBox1.Image.Save
                           (saveFileDialog1.FileName, ImageFormat.Icon);
                        break;
                    case "tiff":
                        pictureBox1.Image.Save
                           (saveFileDialog1.FileName, ImageFormat.Tiff);
                        break;
                }
            }

        }
    }
}
