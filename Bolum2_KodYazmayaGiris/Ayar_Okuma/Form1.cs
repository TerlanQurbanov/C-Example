using System;
using System.Windows.Forms;

namespace Ayar_Okuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text = Properties.Settings.Default.KullanıcıAdı;
                textBox2.Text = Properties.Settings.Default.Sifre;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            } 

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {

        }
    }
}
