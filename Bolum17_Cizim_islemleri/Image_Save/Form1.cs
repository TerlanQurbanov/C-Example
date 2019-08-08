using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
namespace Image_Save
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image image;
        private void btnSec_Click(object sender, EventArgs e)
        {
            DialogResult buton = openFileDialog1.ShowDialog();
            if (buton == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
                FileInfo fInfo = new FileInfo(openFileDialog1.FileName);
                label1.Text = "İlk boyut: " +(fInfo.Length/(1024)).ToString() + " kb";
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageCodecInfo ci;
                Encoder enc;
                EncoderParameter ep;
                EncoderParameters eps;

                ci = EncoderInfo("image/jpeg");
                enc = Encoder.Quality;
                eps = new EncoderParameters(1);

                ep = new EncoderParameter(enc, 25L);
                eps.Param[0] = ep;
                pictureBox1.Image = image;
                image.Save(saveFileDialog1.FileName, ci, eps);
                FileInfo fInfo = new FileInfo(saveFileDialog1.FileName);
                label1.Text = "Yeni boyut: " + (fInfo.Length / (1024)).ToString() + " kb";
            }
        }
        private static ImageCodecInfo EncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }        
    }
}
