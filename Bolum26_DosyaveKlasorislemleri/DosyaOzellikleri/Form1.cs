using System;
using System.IO;
using System.Windows.Forms;
namespace DosyaOzellikleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBilgiAl_Click(object sender, EventArgs e)
        {
            txtOlusturulmaZamanı.Text =
            File.GetCreationTime(textBox1.Text).ToString();
            txtYazımZamanı.Text =
                    File.GetLastWriteTime(textBox1.Text).ToString();
            txtErisimZamanı.Text =
                    File.GetLastAccessTime(textBox1.Text).ToString();
        }
        private void btnBilgiDegistir_Click(object sender, EventArgs e)
        {
            if (txtOlusturulmaZamanı.Text != "")
                File.SetCreationTime(textBox1.Text,
                    Convert.ToDateTime(txtOlusturulmaZamanı.Text));
            if (txtYazımZamanı.Text != "")
                File.SetLastWriteTime(textBox1.Text,
                    Convert.ToDateTime(txtYazımZamanı.Text));
            if (txtErisimZamanı.Text != "")
                File.SetLastAccessTime(textBox1.Text,
                    Convert.ToDateTime(txtErisimZamanı.Text));

        }
    }
}
