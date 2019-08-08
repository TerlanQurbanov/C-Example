using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace struct_to_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct ogrenci
        {
            public string ad;
            public string soyad;
            public int numara;
            public string sınıf;
        }

        ogrenci ogrenciler = new ogrenci();
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(ogrenciler.ad);
            listBox1.Items.Add(ogrenciler.soyad);
            listBox1.Items.Add(ogrenciler.sınıf);
            listBox1.Items.Add(ogrenciler.numara);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenciler.ad = "Talha Osman";
            ogrenciler.soyad = "AKTAŞ";
            ogrenciler.numara = 288;
            ogrenciler.sınıf = "7-D";
        }
    }
}
