using System;
using System.Drawing;
using System.Windows.Forms;
namespace Image_From_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            DialogResult buton= openFileDialog1.ShowDialog();
            if (buton == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;               
            }
        }
    }
}
