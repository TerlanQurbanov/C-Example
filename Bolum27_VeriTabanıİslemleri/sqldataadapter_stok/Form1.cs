using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace sqldataadapter_stok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=stok; Integrated Security=True;Connect Timeout=30; Encrypt=False;TrustServerCertificate=False");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                adaptor = new SqlDataAdapter("select ad,fiyat from urunler", baglantı);
                adaptor.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                txt_ad.DataBindings.Clear();
                txt_ad.DataBindings.Add(new System.Windows.Forms.Binding("text", ds.Tables[0], "ad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                txt_fiyat.DataBindings.Clear();
                txt_fiyat.DataBindings.Add(new System.Windows.Forms.Binding("text", ds.Tables[0], "fiyat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

                baglantı.Open();

                komut = new SqlCommand("select max(fiyat) as maksimum from urunler", baglantı);
                lblenyuksekfiyat.Text = "En yüksek fiyat  " + komut.ExecuteScalar();


                komut = new SqlCommand("select min(fiyat) as minimum from urunler", baglantı);
                lblendusukfiyat.Text = "En düşük fiyat " + komut.ExecuteScalar();

                baglantı.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adaptor = new SqlDataAdapter();
                string insertSQL = "INSERT INTO urunler (ad, fiyat) " + "VALUES (@ad, @fiyat)";

                SqlCommand insertCMD = new SqlCommand(insertSQL, baglantı);
                adaptor.SelectCommand = insertCMD;

                insertCMD.Parameters.Add("@ad", SqlDbType.NVarChar, 15).Value = txt_ad.Text;
                insertCMD.Parameters.Add("@fiyat", SqlDbType.Float, 15).Value = txt_fiyat.Text;

                adaptor.Fill(ds, "urunler");
                MessageBox.Show("Kayıt eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                ds.Clear();
                SqlDataAdapter adp = new SqlDataAdapter("update urunler set ad='" + txt_ad.Text + "', fiyat='" + txt_fiyat.Text + "' Where ad='" + txt_ad.Text + "'", baglantı);

                adp.Fill(ds);
                baglantı.Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                ds.Clear();
                SqlDataAdapter adp = new SqlDataAdapter("delete from urunler Where ad='" + txt_ad.Text + "'", baglantı);
                adp.Fill(ds);
                baglantı.Close();
                MessageBox.Show("Kayıt Silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
        }
    }
}
