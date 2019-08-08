using System;
using System.Windows.Forms;
using System.Configuration;
namespace App_Config
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
                textBox1.Text = ConfigurationManager.AppSettings["KullanıcıAdı"];
                textBox2.Text = ConfigurationManager.AppSettings["Sifre"];
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
