using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_sifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak;
        int toplamhak;
        private void button1_Click(object sender, EventArgs e)
        {
            toplamhak = 3;
            if (textBox1.Text == "deneme")
            {
                MessageBox.Show("Şifre doğru");
            }
            else
            {
                hak = hak + 1;
                MessageBox.Show("Şifre hatalı " +
                (toplamhak - hak) + " hakkınız kaldı");
                if (hak == 3) Application.Exit();
            }

        }
    }
}
