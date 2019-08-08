using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resource_SlideShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Byte i;
        private void btnSlayt_Click(object sender, EventArgs e)
        {
            if (btnSlayt.Text == "Slayt Gösterisini Başlat")
            {
                btnSlayt.Text = "Slayt Gösterisini Bitir";
                timer1.Enabled = true;
                timer1.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000;
            }
            else
            {
                btnSlayt.Text = "Slayt Gösterisini Başlat";
                timer1.Enabled = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
             i++;
            if (i == 1)            
                pictureBox1.Image = Resource1.r1;            
            else if (i == 2)
                pictureBox1.Image = Resource1.r2;
            else if (i == 3)
                pictureBox1.Image = Resource1.r3;
            else if (i == 4)
                pictureBox1.Image = Resource1.r4;
            else if (i == 5)
            {
                pictureBox1.Image = Resource1.r5;
                i = 0;
            } 
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000;
        }
    }
}
