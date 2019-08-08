using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace File_WriteAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyayaYaz_Click(object sender, EventArgs e)
        {
            File.WriteAllText("D:\\ornek.txt", textBox1.Text);
            MessageBox.Show("Dosya oluşturuldu ve yazılar eklendi");
        }
    }
}
