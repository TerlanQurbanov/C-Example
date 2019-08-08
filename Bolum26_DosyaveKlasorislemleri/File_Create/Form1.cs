using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace File_Create
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyayaYaz_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Create("D:\\ornek.txt");
            byte[] text = new UTF8Encoding(true).
                GetBytes("www.kodlab.com");
            fs.Write(text, 0, text.Length);
            fs.Close();
            MessageBox.Show("Dosya oluşturuldu ve yazılar eklendi");

        }
    }
}
