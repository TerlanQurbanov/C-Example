using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Metodlar
        {
            public void Mesaj(string mesaj, string baslık)
            {
                MessageBox.Show(baslık, mesaj);
            }
            public void Topla(int sayi1, int sayi2)
            {
                Mesaj("Toplam", (sayi1 + sayi2).ToString());
            }
            public void Cıkar(int sayi1, int sayi2)
            {
                Mesaj("Fark", (sayi1 - sayi2).ToString());
            }
        }
        public delegate void Del_Metod(int sayi1, int sayi2);
        Metodlar metod = new Metodlar();
        private void btnMesaj_Click(object sender, EventArgs e)
        {
            //Del_Metod ehTopla = metod.Topla;
            //Del_Metod ehCıkar = metod.Cıkar;
            //ehTopla(5, 10);
            //ehCıkar(5, 10);
            Del_Metod event_handler = new Del_Metod(metod.Topla);
            event_handler += metod.Cıkar;
            event_handler.Invoke(5, 10); 
        }
    }
}
