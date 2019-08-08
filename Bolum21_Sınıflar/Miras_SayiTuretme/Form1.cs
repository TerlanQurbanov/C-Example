using System;
using System.Windows.Forms;
namespace Miras_SayiTuretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temel_Sinif.snf_mirascı nsn_sayi = new Temel_Sinif.snf_mirascı();
            textBox1.Text = nsn_sayi.mtd_turet().ToString(); ;
        }
    }
}
