using System;
using System.Drawing;
using System.Windows.Forms;
namespace Image_Rotate_And_Flip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (RotateFlipType degerler in Enum.GetValues(typeof(RotateFlipType)))
            { this.comboBox1.Items.Add(degerler); }
            this.comboBox1.SelectedIndex=0;
            this.comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                RotateFlipType rt = (RotateFlipType)comboBox1.SelectedItem;
                Image image = pictureBox1.Image;
                image.RotateFlip(rt);
                pictureBox1.Refresh();
            }
        }        
        private void btnSec_Click(object sender, EventArgs e)
        {
            DialogResult buton = openFileDialog1.ShowDialog();
            if (buton == DialogResult.OK)
            {
               Image image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }
        }              
    }
}
