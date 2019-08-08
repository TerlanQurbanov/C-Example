using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace regex_rakamsayı_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAdSoyad_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z\\s]{1,30}$");
            if (!regex.Match(txtAdSoyad.Text).Success)
            {
                MessageBox.Show
                    ("30 karakter uzunluğunda bir string girebilirsiniz!");
                txtAdSoyad.Focus();
            }
        }

        private void txtNumara_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("^\\d*$");
            if (!regex.Match(txtNumara.Text).Success)
            {
                MessageBox.Show("Yalnızca rakam girebilirsiniz!");
                txtNumara.Focus();
            }
        }

        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex
               ("^[01]?[- .]?(\\([2-9]\\d{2}\\)|[2-9]\\d{2})[- .]?\\d{3}[- .]?\\d{4}$");
            if (!regex.Match(txtTelefon.Text).Success)
            {
                MessageBox.Show("Telefon numarasında yanlışlık var!");
                txtTelefon.Focus();
            }
        }

        private void txtTCKimlik_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("^\\d{11}$");
            if (!regex.Match(txtTCKimlik.Text).Success)
            {
                MessageBox.Show("T.C. Kimlik numarasında yanlışlık var!");
                txtTCKimlik.Focus();
            }
        }
    }
}
