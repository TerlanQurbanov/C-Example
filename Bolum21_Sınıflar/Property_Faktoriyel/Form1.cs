using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Property_Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnislem_Click(object sender, EventArgs e)
        {
            faktoriyel nsn_faktoriyel = new faktoriyel();
            nsn_faktoriyel.deger = Convert.ToInt32(txtSayi.Text);
            txtSonuc.Text = nsn_faktoriyel.deger.ToString();
            lblBasamak.Text = "Basamak Sayısı= " +  nsn_faktoriyel.basamak_sayisi;
        }
    }
    class faktoriyel
    {
        int i, sayi, sonuc;
        public int deger
        {
            get
            {
                sonuc = 1;
                for (i = 1; i <= sayi; i++)
                {
                    sonuc = sonuc * i;
                }
                return sonuc;
            }
            set
            { sayi = value; }
        }
        public int basamak_sayisi
        {
            get
            {
                return (sonuc.ToString().Length);
            }
        }
    }
}
