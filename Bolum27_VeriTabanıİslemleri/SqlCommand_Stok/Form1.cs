using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace SqlCommand_Stok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=stok;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            if ((baglantı.State == ConnectionState.Closed)) baglantı.Open();

            komut = new SqlCommand("select * from urunler ", baglantı);

            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                txt_ad.Text = reader["ad"].ToString();
                txt_fiyat.Text = reader.GetDecimal(4).ToString();
            }

            reader.Close();
            adaptor.SelectCommand = new SqlCommand("select ad,fiyat from urunler ", baglantı);
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            komut = new SqlCommand("SELECT TOP 1 ad FROM urunler ORDER BY NEWID()", baglantı);
            lblrastgeleurun.Text = "Günün indirimli ürünü " + komut.ExecuteScalar();

            komut = new SqlCommand("Select Count(*) From urunler", baglantı);
            lblKayıtSayısı.Text = "Veritabanında " + (int)komut.ExecuteScalar() + " tane ürün var.";
            baglantı.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satirno;

            satirno = e.RowIndex;

            txt_ad.Text = dataGridView1.Rows[satirno].Cells[0].Value.ToString();
            txt_fiyat.Text = dataGridView1.Rows[satirno].Cells[1].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                ds.Clear();

                SqlCommand komut = new SqlCommand("insert into urunler (ad,fiyat) Values ('" + txt_ad.Text + "','" + txt_fiyat.Text + "')", baglantı);
                komut.ExecuteNonQuery();
                dataGridView1.Update();
                baglantı.Close();
                MessageBox.Show("Kayıt Eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                ds.Clear();

                SqlCommand komut = new SqlCommand("update urunler set ad='" + txt_ad.Text + "', fiyat='" + txt_fiyat.Text + "' Where ad='" + txt_ad.Text + "'", baglantı);
                komut.ExecuteNonQuery();
                dataGridView1.Update();
                baglantı.Close();
                MessageBox.Show("Kayıt Güncellendi!");
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
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                ds.Clear();

                SqlCommand komut = new SqlCommand("delete from urunler Where ad='" + txt_ad.Text + "'", baglantı);
                komut.ExecuteNonQuery();
                dataGridView1.Update();
                dataGridView1.Refresh();
                baglantı.Close();
                MessageBox.Show("Kayıt Silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
        }
    }
}
