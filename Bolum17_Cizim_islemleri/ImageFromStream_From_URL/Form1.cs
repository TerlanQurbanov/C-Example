using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
namespace ImageFromStream_From_URL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResimGoruntule_Click(object sender, EventArgs e)
        {
            var wr = WebRequest.Create(textBox1.Text);
            using (var response = wr.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
            //pictureBox1.ImageLocation = textBox1.Text;
        }
    }
}
