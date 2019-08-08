using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Equals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            string tarih1;
            bool sonuc;
            tarih1 = string.Format("{0:d}", txtTarih1.Text);
            string tarih2;
            tarih2 = string.Format("{0:d}", txtTarih2.Text);
            sonuc = tarih1.Equals(tarih2);
            if (sonuc == true)
                lblSonuc.Text = "Her iki tarih değeri birbirine eşit";
            else
                lblSonuc.Text = "Tarih değerleri birbirinden farklı";

        }
    }
}
