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

namespace Deger_Donduren_Metod_NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public byte NotHesapla(byte notu)
        {
            byte puan = 0;
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
            byte notdegeri = 0;
            notdegeri = Convert.ToByte(Interaction.
                InputBox("Notunuzu Girin"));
            MessageBox.Show("Puanınız= " + NotHesapla(notdegeri));

        }
    }
}
