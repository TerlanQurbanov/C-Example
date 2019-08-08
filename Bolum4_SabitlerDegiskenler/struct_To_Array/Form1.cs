using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace struct_To_Array
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
        ogrenci[] ogrenciler = new ogrenci[3];
        byte i;

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= ogrenciler.Length - 1; i++)
            {
                listBox1.Items.Add(ogrenciler[i].ad);
                listBox1.Items.Add(ogrenciler[i].soyad);
                listBox1.Items.Add(ogrenciler[i].sınıf);
                listBox1.Items.Add(ogrenciler[i].numara);
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 2; i++)
            {
                ogrenciler[i].ad = Interaction.InputBox
                    (i + ". öğrencinin adını giriniz");
                ogrenciler[i].soyad = Interaction.InputBox
                    (i + ". öğrencinin soyadını giriniz");
                ogrenciler[i].sınıf = Interaction.InputBox
                    (i + ". öğrencinin sınıfını giriniz");
                ogrenciler[i].numara = Convert.ToInt32
                    (Interaction.InputBox(i +
                    ". öğrencinin numarasını giriniz"));
            }
        }

    }
}
