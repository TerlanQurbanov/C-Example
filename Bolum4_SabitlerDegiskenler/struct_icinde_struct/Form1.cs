using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace struct_icinde_struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct ogrenci
        {
            public string adsoyad;
            public int numara;
            public string sınıf;
            public struct veli_bilgi
            {
                public string adı;
                public string ev_telefonu;
                public string is_telefonu;
                public string cep_telefonu;
            }
        }
        ogrenci ogrenciler = new ogrenci();
        ogrenci.veli_bilgi veli = new ogrenci.veli_bilgi();
        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenciler.adsoyad = "Talha Osman AKTAŞ";
            ogrenciler.numara = 288;
            ogrenciler.sınıf = "7-D";
            veli.adı = "Volkan AKTAŞ";
            veli.ev_telefonu = "2251111";
            veli.is_telefonu = "4731111";
            veli.cep_telefonu = "5XX1111111";
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(ogrenciler.adsoyad);
            listBox1.Items.Add(ogrenciler.sınıf);
            listBox1.Items.Add(ogrenciler.numara);
            listBox1.Items.Add(veli.ev_telefonu);
            listBox1.Items.Add(veli.is_telefonu);
            listBox1.Items.Add(veli.cep_telefonu);
        }
    }
}
