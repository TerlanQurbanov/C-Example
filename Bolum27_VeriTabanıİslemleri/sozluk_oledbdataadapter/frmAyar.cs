using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
namespace sozluk_oledbdataadapter
{
    public partial class frmAyar : Form
    {
        public frmAyar()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/sozluk.accdb");
        private void frmAyar_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if ((baglantı.State == ConnectionState.Closed))
                    baglantı.Open();

                OleDbDataAdapter adp = new OleDbDataAdapter("Select * from sozcukler", baglantı);

                adp.Fill(ds);
                lstsonuc.DataSource = ds.Tables[0];
                lstsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add(new System.Windows.Forms.Binding("text", ds.Tables[0], "turkce", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                baglantı.Close();
                lstsonuc.SelectedIndex = 0;
                txtingilizce.Text = lstsonuc.Text;
                txtturkce.Text = txtsonuc.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
        }
        private void lstsonuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstsonuc.SelectedItem.ToString();
            txtingilizce.Text = lstsonuc.Text;
            txtturkce.Text = txtsonuc.Text;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtingilizce.Clear();
            txtturkce.Clear();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtingilizce.Text) | string.IsNullOrEmpty(txtturkce.Text))
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz", "Hata");
                return;
            }
            try
            {
                DataSet ds = new DataSet();
                baglantı.Open();
                //Bağlantımızı açıyoruz.Veritabanı işlemi yapmadan önce bağlantımızı açmamız gerekiyor.
                ds.Clear();
                //Text her değiştiğinde veriler birbirine karışmasın diye Verisetimizi sıfırlıyoruz.Veri seti sıfırlanınca NULL olur
                OleDbDataAdapter adp = new OleDbDataAdapter("insert into sozcukler (ingilizce,turkce) Values ('" + txtingilizce.Text + "','" + txtturkce.Text + "')", baglantı);
                adp.Fill(ds);
                //Adapter nesnemizi Verisetimize dolduruyoruz

                baglantı.Close();
                //Bağlantımızı kapatıyoruz
                MessageBox.Show("Kayıt Eklendi", "Bilgi");
                txtingilizce.Text = "";
                txtturkce.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //eğer bir hata oluşursa Hata sebebini bize mesajla bildirmesini söylüyoruz
                baglantı.Close();
                //Bağlantımızı kapatıyoruz
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                baglantı.Open();
                //Bağlantımızı açıyoruz.Veritabanı işlemi yapmadan önce bağlantımızı açmamız gerekiyor.
                ds.Clear();
                //Text her değiştiğinde veriler birbirine karışmasın diye Verisetimizi sıfırlıyoruz.Veri seti sıfırlanınca NULL olur
                OleDbDataAdapter adp = new OleDbDataAdapter("update sozcukler set ingilizce='" + txtingilizce.Text + "', turkce='" + txtturkce.Text + "' Where ingilizce='" + txtingilizce.Text + "'", baglantı);
                adp.Fill(ds);
                //Adapter nesnemizi Verisetimize dolduruyoruz

                baglantı.Close();
                //Bağlantımızı kapatıyoruz        
                MessageBox.Show("Kayıt Güncellendi.", "Bilgi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //eğer bir hata oluşursa Hata sebebini bize mesajla bildirmesini söylüyoruz
                baglantı.Close();
                //Bağlantımızı kapatıyoruz
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                baglantı.Open();
                //Bağlantımızı açıyoruz.Veritabanı işlemi yapmadan önce bağlantımızı açmamız gerekiyor.
                ds.Clear();
                //Text her değiştiğinde veriler birbirine karışmasın diye Verisetimizi sıfırlıyoruz.Veri seti sıfırlanınca NULL olur
                OleDbDataAdapter adp = new OleDbDataAdapter("delete from sozcukler Where ingilizce='" + txtingilizce.Text + "'", baglantı);
                adp.Fill(ds);
                //Adapter nesnemizi Verisetimize dolduruyoruz

                baglantı.Close();
                //Bağlantımızı kapatıyoruz

                MessageBox.Show("Kayıt Silindi", "Bilgi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //eğer bir hata oluşursa Hata sebebini bize mesajla bildirmesini söylüyoruz
                baglantı.Close();
                //Bağlantımızı kapatıyoruz
            }
        }
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
