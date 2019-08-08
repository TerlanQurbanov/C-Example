using System;
using System.Windows.Forms;
namespace Override
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMesaj_Click(object sender, EventArgs e)
        {
            Turemis_Sınıf ortalama = new Turemis_Sınıf();
            ortalama.yazılı1 = 60;
            ortalama.yazılı2 = 60;
            ortalama.sozlu = 60;
            ortalama.odev = 80;
           //((Hesapla)ortalama).yazılı1 = 55;        
            MessageBox.Show("Ortalama = " +  ortalama.islem());
        }
    }
}
