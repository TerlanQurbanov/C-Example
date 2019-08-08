using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Compare
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
            int sonuc;
            tarih1 = string.Format("{0:d}", txtTarih1.Text);
            string tarih2;
            tarih2 = string.Format("{0:d}", txtTarih2.Text);
            sonuc = tarih1.CompareTo(tarih2);
            switch (sonuc)
            {
                case -1:
                    lblSonuc.Text = "Birinci tarih değeri ikincisinden küçük";
                    return;
                case 1:
                    lblSonuc.Text = "Birinci tarih değeri ikincisinden büyük";
                    return;
                case 0:
                    lblSonuc.Text = "Her iki tarih değeri birbirine eşit";
                    return;
            }
        }
    }
}
