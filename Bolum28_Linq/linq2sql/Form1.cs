using System;
using System.Linq;
using System.Windows.Forms;
namespace linq2sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cs = "Data Source=(localdb)\\Projects;Initial Catalog=mydb;Integrated Security=True;Connect Timeout=30";
        private void btnEkle_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext veriler = new DataClasses1DataContext(cs);
            tblogr ogr = new tblogr() { isim = txtAd.Text, soyisim = txtSoyad.Text, numara = Convert.ToInt32(txtNo.Text), sinif = cmbsinif.Text };
            veriler.tblogrs.InsertOnSubmit(ogr);
            veriler.SubmitChanges();
            MessageBox.Show("Kayıt Eklendi");
        }
        private void btnOku_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext veriler = new DataClasses1DataContext();
            var ogr = from veri in veriler.tblogrs where veri.numara == 166 select veri.sinif;
            foreach (var gelen in ogr)
                MessageBox.Show(gelen.ToString());      
        }
        private void btnSınıfDeg_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext veriler = new DataClasses1DataContext();

            tblogr tabloogr = (from ogr in veriler.tblogrs where ogr.numara == 166 select ogr).SingleOrDefault();
            tabloogr.sinif = "1-B";
            veriler.SubmitChanges();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {            
            DataClasses1DataContext veriler = new DataClasses1DataContext(cs);
            tblogr tabloogr = (from ogr in veriler.tblogrs where ogr.numara == 166 select ogr).SingleOrDefault();
            veriler.tblogrs.DeleteOnSubmit(tabloogr);
            veriler.SubmitChanges();
        }
    }
}
