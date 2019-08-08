using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_kontrolu_baglantılı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte i;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 5)
            {
                MessageBox.Show("Timer1 saymayı bitirdi. Şimdi sıra Timer2 de.");
                timer1.Enabled = false;
                timer2.Enabled = true;
                i = 0;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 3)
            {
                MessageBox.Show("Timer2 de saymayı bitirdi.");
                timer2.Enabled = false;
            }
        }
    }
}
