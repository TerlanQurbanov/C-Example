using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Microsoft.Win32;
using System.IO;
namespace sozluk_oledbdataadapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/sozluk.accdb");
        private void btnAyar_Click(object sender, EventArgs e)
        {
            frmAyar frmayar = new frmAyar();
            frmayar.Show();        }

        private void txtaranan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if ((baglantı.State == ConnectionState.Closed))
                    baglantı.Open();

                OleDbDataAdapter adp = new OleDbDataAdapter("Select * from sozcukler where ingilizce LIKE '" + txtaranan.Text + "%'", baglantı);

                adp.Fill(ds);
                lstsonuc.DataSource = ds.Tables[0];
                lstsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add(new System.Windows.Forms.Binding("text", ds.Tables[0], "turkce", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                baglantı.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey anahtar = Registry.CurrentUser.OpenSubKey("Software", true);
            if (anahtar.OpenSubKey("Sözlük") != null)
            {
                byte tekrar = Convert.ToByte(anahtar.OpenSubKey("Sözlük", true).GetValue("CalismaSayisi").ToString());
                anahtar.OpenSubKey("Sözlük", true).SetValue("CalismaSayisi", tekrar + 1, RegistryValueKind.String);
                if (DateTime.Now.ToString().Substring(0, 2) == "01")
                {
                    RegistryKey duzenkey = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("Sözlük", true);
                    if (duzenkey.GetValue("DuzenlemeZamanı") == null)
                    {
                        mdb_duzenle();
                        duzenkey.SetValue("DuzenlemeZamanı", DateTime.Now.ToString().Substring(1, 10));
                    }
                }
                else
                {
                    RegistryKey duzenkey = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("Sözlük", true);
                    if (duzenkey.GetValue("DuzenlemeZamanı") != null)
                    {
                        duzenkey.DeleteValue("DuzenlemeZamanı");
                    }
                }
            }
            else
            {
                anahtar.CreateSubKey("Sözlük");
                anahtar.OpenSubKey("Sözlük", true).SetValue("CalismaSayisi", 1, RegistryValueKind.String);
                MessageBox.Show("Program Bu Bilgisayarda İlk Defa Çalışıyor");
            }
            anahtar.Close();
        }
        private void mdb_duzenle()
        {
            JRO.JetEngine jro = default(JRO.JetEngine);
            jro = new JRO.JetEngine();

            jro.CompactDatabase("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/sozluk.accdb", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/yenisozluk.accdb;" + "Jet OLEDB:Engine Type=5");
            File.Delete(Application.StartupPath + "/sozluk.accdb");
            File.Copy(Application.StartupPath + "/yenisozluk.accdb", Application.StartupPath + "/sozluk.accdb");
            File.Delete(Application.StartupPath + "/yenisozluk.accdb");
            MessageBox.Show("Veritabanına Bakım ve Düzenleme İşlemi Yapıldı");
        }
    }
}
