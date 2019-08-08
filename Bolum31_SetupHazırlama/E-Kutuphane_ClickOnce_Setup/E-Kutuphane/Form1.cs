using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
namespace E_Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\kutuphane.accdb");        
        OleDbCommand komut = new OleDbCommand();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (baglantı.State == ConnectionState.Closed)
                baglantı.Open();
            komut = new OleDbCommand("SELECT * FROM kullanici ", baglantı);          
            string gel_kul, gel_sifre;
          
            OleDbDataReader oku = komut.ExecuteReader();
            oku.Read();
            gel_kul = oku.GetValue(1).ToString();
            gel_sifre = oku.GetValue(2).ToString();
            if ((gel_kul == txtKullaniciAdi.Text) && (gel_sifre == txtSifre.Text))
            {               

                btnAyarlar.Visible = true;
                grpLogOut.Visible = true;
                grpLogOut.Top = 12;
                grpLogOut.Left = 464;

                grpLogin.Top = 152;
                grpLogin.Left = 464;
                grpLogin.Visible = false;

                lblKullaniciAdi.Text = gel_kul + " kullanıcısı" +Environment.NewLine + "giriş yaptı" ;
                btn_Ekle.Enabled = true;
                btn_Kaydet.Enabled = true;
                btn_Sil.Enabled = true;
                btnYazdır.Enabled = true;

                
            }
            else if ((txtKullaniciAdi.Text != gel_kul) || (txtSifre.Text != gel_sifre))
            {
                MessageBox.Show("Yanlış Şifre veya Kullanıcı Adı");
            }
            else
            {
                MessageBox.Show("Yanlış Şifre veya Kullanıcı Adı");
            }
            oku.Close();
            baglantı.Close();

        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            btnAyarlar.Visible = false;
            grpLogOut.Top = 152;
            grpLogOut.Left = 464;
            grpLogOut.Visible = false;

            grpLogin.Visible = true;
            grpLogin.Top = 12;
            grpLogin.Left = 464;          
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAramaKriteri.SelectedIndex = 0;
            cmbYazdırmaKriteri.SelectedIndex = 0;
            try
            {
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();

                OleDbDataAdapter adp = new OleDbDataAdapter("Select * from kitaplar where KitapAdi LIKE '" + txtaranan.Text + "%'", baglantı);
                adp.Fill(ds);
                lstsonuc.DataSource = ds.Tables[0];
                lstsonuc.DisplayMember = "KitapAdi";                
                txtAdet.DataBindings.Clear();
                txtAdet.DataBindings.Add(new System.Windows.Forms.Binding("text", ds.Tables[0], "Adet", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                txtBaskiNo.DataBindings.Clear();
                txtBaskiNo.DataBindings.Add(new System.Windows.Forms.Binding("text", ds.Tables[0], "BaskiNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                txtDurum.DataBindings.Clear();
                txtDurum.DataBindings.Add(new System.Windows.Forms.Binding("text", ds.Tables[0], "MevcutDurumu", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                txtKitapAdi.DataBindings.Clear();
                txtKitapAdi.DataBindings.Add(new System.Windows.Forms.Binding("text", ds.Tables[0], "KitapAdi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                txtYazarAdi.DataBindings.Clear();
                txtYazarAdi.DataBindings.Add(new System.Windows.Forms.Binding("text", ds.Tables[0], "YazarAdi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                baglantı.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                baglantı.Close();
            }
        }        

        private void txtaranan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();

                if (cmbAramaKriteri.Text == "Kitap Adı")
                {
                    OleDbDataAdapter adp = new OleDbDataAdapter("Select * from kitaplar where KitapAdi LIKE '" + txtaranan.Text + "%'", baglantı);
                    adp.Fill(ds);
                    lstsonuc.DataSource = ds.Tables[0];
                    lstsonuc.DisplayMember = "KitapAdi";
                }
                else
                {
                    OleDbDataAdapter adp = new OleDbDataAdapter("Select * from kitaplar where YazarAdi LIKE '" + txtaranan.Text + "%'", baglantı);
                    adp.Fill(ds);
                    lstsonuc.DataSource = ds.Tables[0];
                    lstsonuc.DisplayMember = "YazarAdi";
                }
               
                baglantı.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                baglantı.Close();
            }
        }

        private void cmbAramaKriteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();

                if (cmbAramaKriteri.Text == "Kitap Adı")
                {
                    OleDbDataAdapter adp = new OleDbDataAdapter("Select * from kitaplar where KitapAdi LIKE '" + txtaranan.Text + "%'", baglantı);
                    adp.Fill(ds);
                    lstsonuc.DataSource = ds.Tables[0];
                    lstsonuc.DisplayMember = "KitapAdi";
                }
                else
                {
                    OleDbDataAdapter adp = new OleDbDataAdapter("Select * from kitaplar where YazarAdi LIKE '" + txtaranan.Text + "%'", baglantı);
                    adp.Fill(ds);
                    lstsonuc.DataSource = ds.Tables[0];
                    lstsonuc.DisplayMember = "YazarAdi";
                }               
                baglantı.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                baglantı.Close();
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) | string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyad Alanlarını Doldurunuz", "Hata");
                return;
            }
            else if (!(string.IsNullOrEmpty(txtDurum.Text)))
            {
                MessageBox.Show("Seçili kitap bir başkasına verilmiş", "Hata");
                return;
            }
            else
            {
                //try
                //{
                    DataSet ds = new DataSet();
                    if (baglantı.State == ConnectionState.Closed)
                        baglantı.Open();
                    ds.Clear();

                    OleDbCommand komut = new OleDbCommand("INSERT INTO kitap_kayit (KitapAdi,MevcutDurumu,AliciAdi,AliciSoyad,AliciSinifi,AliciNo,AliciMail) VALUES ('" + txtKitapAdi.Text + "','" + txtKitapAlimTarihi.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtSinif.Text + "','" + txtNo.Text + "','" + txtMail.Text + "')", baglantı);
                    komut.ExecuteNonQuery();

                    OleDbCommand kitapkomut = new OleDbCommand("UPDATE kitaplar SET YazarAdi='" + txtYazarAdi.Text + "',KitapAdi='" + txtKitapAdi.Text + "', BaskiNo='" + txtBaskiNo.Text + "',Adet='" + txtAdet.Text + "',MevcutDurumu='" + txtKitapAlimTarihi.Text + "' WHERE KitapAdi='" + txtKitapAdi.Text + "'", baglantı);
                    kitapkomut.ExecuteNonQuery();
                   
                    baglantı.Close();
                    MessageBox.Show("Kayıt Eklendi!");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                    baglantı.Close();
                //}
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed)
                    baglantı.Open();
                ds.Clear();
                OleDbCommand komut = new OleDbCommand("UPDATE kitap_kayit SET KitapAdi='" + txtKitapAdi.Text + "',MevcutDurumu='" + txtKitapAlimTarihi.Text + "', AliciAdi='" + txtAd.Text + "', AliciSoyad='" + txtSoyad.Text + "', AliciSinifi='" + txtSinif.Text + "',AliciNo='" + txtNo.Text + "',AliciMail='" + txtMail.Text + "' WHERE KitapAdi='" + txtKitapAdi.Text + "'", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kayıt Güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed)
                    baglantı.Open();
                ds.Clear();

                OleDbCommand komut = new OleDbCommand("DELETE FROM kitap_kayit WHERE KitapAdi='" + txtKitapAdi.Text + "'", baglantı);
                komut.ExecuteNonQuery();

                baglantı.Close();
                MessageBox.Show("Kayıt Silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
        }

        private void cmdcikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frmAyarlar = new Form2();
            frmAyarlar.Show();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            try
            {
                Word.Application WordApp = new Word.Application();
                Word.Document WordDoc = new Word.Document();

                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();


                if (Directory.Exists(Application.StartupPath + "\\dosyalar"))
                {
                   
                    Directory.SetCurrentDirectory(Application.StartupPath + "\\dosyalar");
                    if (!Directory.Exists(Application.StartupPath + "\\dosyalar" + "\\" + "listeler"))
                        Directory.CreateDirectory(Application.StartupPath + "\\dosyalar" + "\\" + "listeler");
                    Directory.SetCurrentDirectory(Application.StartupPath + "\\dosyalar" + "\\" + "listeler");                        
                }
                string yolu = Directory.GetCurrentDirectory();
             
                if (cmbYazdırmaKriteri.Text == "Tüm Kitaplar")
                {
                    OleDbCommand komut = new OleDbCommand("Select YazarAdi,KitapAdi from kitaplar", baglantı);
                    OleDbDataReader reader = komut.ExecuteReader();
                  
                    WordDoc = WordApp.Documents.Open(Application.StartupPath + "\\bos_kitaplar.docx");                   
                    WordApp.Visible = true;                  
                                                  
                    int i = 2;
                    while (reader.Read())
                    {                                           
                        WordDoc.Range().Tables[1].Cell(i, 1).Range.InsertAfter(reader["YazarAdi"].ToString());
                        WordDoc.Range().Tables[1].Cell(i, 2).Range.InsertAfter(reader["KitapAdi"].ToString());
                        WordDoc.Range().Tables[1].Rows.Add();   
                        i++;
                    }
                    WordDoc.SaveAs(yolu + "\\tum_kitaplar" + ".doc");                    
                    WordDoc.Close();
                    WordApp.Quit();

                    WordDoc = null;
                    WordApp = null;

                    MessageBox.Show("Sorular WORD'a aktarıldı!");
                }
                baglantı.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                baglantı.Close();
            }
        }

      
    }
}
