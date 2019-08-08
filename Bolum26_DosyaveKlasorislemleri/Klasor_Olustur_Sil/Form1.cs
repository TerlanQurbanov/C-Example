using System;
using System.IO;
using System.Windows.Forms;
namespace Klasor_Olustur_Sil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlasorOlustur_Click(object sender, EventArgs e)
        {          
            if (Directory.Exists(textBox1.Text))
            {
                MessageBox.Show("Klasör Mevcut. " +
                    Directory.GetCreationTime(textBox1.Text) +
                    "  tarihinde oluşturulmuş");
            }
            else
            {
                Directory.CreateDirectory(textBox1.Text);
                MessageBox.Show("Klasör oluşturuldu");
            }
        }
        private void btnKlasorSil_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                Directory.Delete(textBox1.Text, true);
                MessageBox.Show("Klasör silindi");
            }
            else
                MessageBox.Show("Klasör mevcut değil");
        }
    }
}
