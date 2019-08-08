using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
namespace sozluk_oledbcommand
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/sozluk.accdb");
        OleDbDataAdapter adaptor = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();      

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                ds.Clear();

                OleDbCommand komut = new OleDbCommand("insert into sozcukler (ingilizce,turkce) Values ('" + txt_ingilizce.Text + "','" + txt_turkce.Text + "')", baglantı);
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

                OleDbCommand komut = new OleDbCommand("update sozcukler set ingilizce='" + txt_ingilizce.Text + "', turkce='" + txt_turkce.Text + "' Where ingilizce='" + txt_ingilizce.Text + "'", baglantı);
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

                OleDbCommand komut = new OleDbCommand("delete from sozcukler Where ingilizce='" + txt_ingilizce.Text + "'", baglantı);
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

        private void Form2_Load(object sender, EventArgs e)
        {
            if ((baglantı.State == ConnectionState.Closed)) baglantı.Open();

            komut = new OleDbCommand("select * from sozcukler ", baglantı);


            OleDbDataReader reader = komut.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                txt_turkce.Text = reader["turkce"].ToString();
                txt_ingilizce.Text = reader.GetString(1).ToString();
            }

            adaptor.SelectCommand = new OleDbCommand("select ingilizce,turkce from sozcukler ", baglantı);
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            komut = new OleDbCommand("Select Count(*) From sozcukler", baglantı);
            lblKayıtSayısı.Text = "Veritabanında " + (int)komut.ExecuteScalar() + " tane kelime var.";
            baglantı.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satirno;
            satirno = e.RowIndex;
            txt_ingilizce.Text = dataGridView1.Rows[satirno].Cells[0].Value.ToString();
            txt_turkce.Text = dataGridView1.Rows[satirno].Cells[1].Value.ToString();
        }
    }
}
