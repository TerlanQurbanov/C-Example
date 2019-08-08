using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anonymous_ToplamaCikarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        public delegate void Del_Metod(int sayi1, int sayi2);
        Del_Metod Mesaj = delegate(int sayi1, int sayi2)
        {
            MessageBox.Show((sayi1 + sayi2).ToString(),"Sonuç");
        };
        private void btnMesaj_Click(object sender, EventArgs e)
        {
            Mesaj(5,10);
        }
    }
}
