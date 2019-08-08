using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace ImageFromStream
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
                using (FileStream stream = File.Open(openFileDialog1.FileName, FileMode.Open))
                using (Image image = Image.FromStream(stream))
                {                    
                    pictureBox1.Image = Bitmap.FromStream(stream);
                    lblBoyut.Text = image.Size.ToString();
                }                
            }
        }
    }
}
