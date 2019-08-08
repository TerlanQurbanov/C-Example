using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Mesaj(string mesaj, string baslık)
        {
            MessageBox.Show(baslık, mesaj);
        }
        public void Topla(int sayi1, int sayi2, Del_Metod Mesaj)
        {
            Mesaj("Sonuç", (sayi1 + sayi2).ToString());
        }
        public delegate void Del_Metod(string mesaj, string baslık);
        private void btnMesaj_Click(object sender, EventArgs e)
        {
            Del_Metod event_handler = new Del_Metod(Mesaj);
            Topla(5, 10, event_handler);
        }
    }
}
