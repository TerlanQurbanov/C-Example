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
namespace if_sayi_tahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak, tahmininiz, sayi;
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (hak == 0) btnTahmin.Enabled = false;
            tahmininiz = Convert.ToInt32(Interaction.InputBox
                ("Tahmininizi Giriniz"));
           if ((Convert.ToInt32(tahmininiz) <= 100) &
                    (Convert.ToInt32(tahmininiz) >= 0))
           {
               if (sayi < 100 | sayi >= 0)
               {
                   if (tahmininiz < sayi)
                       lblMesaj.Text =
                         "Daha Büyük!" + hak + " hakkiniz kaldi";
                   if (tahmininiz > sayi)
                       lblMesaj.Text =
                         "Daha Küçük!" + hak + " hakkiniz kaldi";
                   if (tahmininiz == sayi)
                       lblMesaj.Text =
                         "Tebrik ederim! Bildiniz...";
                   if (hak > 0)
                   {
                       hak = hak - 1;
                   }
                   else
                   {
                       lblMesaj.Text =
                         "Sayıyı Bulamadınız. Tutulan sayı = " + sayi;
                   }
               }
           }           
        }
        private void uret()
        {
            sayi = 0;
            Random rastgele = new Random();
            int tutulansayi = rastgele.Next(1, 100);
            sayi = tutulansayi;
        }
        private void btnBasla_Click(object sender, EventArgs e)
        {
            hak = 5;
            lblMesaj.Text = "...";
            btnTahmin.Enabled = true;
            uret();

        }
    }
}
