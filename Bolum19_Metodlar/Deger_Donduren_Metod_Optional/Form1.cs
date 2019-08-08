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

namespace Deger_Donduren_Metod_Optional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public byte NotHesapla(byte yazılı, byte sozlu = 0)
        {
            byte puan = 0;
            int notu = 0;
            if (sozlu > 0)
                notu = (yazılı + sozlu) / 2;
            else
                notu = yazılı;

            if (notu < 25)
                puan = 0;
            else if (notu < 45)
                puan = 1;
            else if (notu < 55)
                puan = 2;
            else if (notu < 70)
                puan = 3;
            else if (notu < 85)
                puan = 4;
            else if (notu <= 100)
                puan = 5;
            else
                MessageBox.Show("Yanlış Not Girdiniz");
            return puan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            byte yazılınotu = 0;
            byte sozlunotu = 0;

            yazılınotu = Convert.ToByte(Interaction.
                InputBox("Yazılı Notunuzu Girin"));
            sozlunotu = Convert.ToByte(Interaction.
                InputBox("Sözlü Notunuzu Girin"));

            if (sozlunotu == 0)
                MessageBox.Show("Puanınız= " +
                    NotHesapla(yazılınotu, 0));
            else
                MessageBox.Show("Puanınız= " +
                NotHesapla(yazılınotu, sozlunotu)); 
        }
    }
}
