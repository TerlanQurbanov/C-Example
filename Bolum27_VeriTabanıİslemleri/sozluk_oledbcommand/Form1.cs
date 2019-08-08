using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
namespace sozluk_oledbcommand
{
    public partial class frmSifre : Form
    {
        public frmSifre()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/sozluk.accdb"); 
        OleDbCommand komut = new OleDbCommand();
        string deger;
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (baglantı.State == ConnectionState.Closed)
                baglantı.Open();
            komut = new OleDbCommand("select * from sifre where sifre='" +
                txtSifre.Text + "' ", baglantı);
            try
            {
                deger = komut.ExecuteScalar().ToString();
                if (Convert.ToInt32(deger) == 1)
                {
                    MessageBox.Show("Şifre doğru");
                    baglantı.Close();
                    this.Hide();
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                else                
                    MessageBox.Show("Şifre yanlış");                
                baglantı.Close();
            }
            catch { }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
