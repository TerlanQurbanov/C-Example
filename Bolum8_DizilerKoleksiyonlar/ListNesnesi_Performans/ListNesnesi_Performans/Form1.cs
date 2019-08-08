using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListNesnesi_Performans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime başlangıçzamanı;
        DateTime bitiş;
        TimeSpan fark;        
        private void btnAktar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rasgele = new Random();
            int sayı;
            for (int i = 0; i < 100000; i++)
            {
                sayı = rasgele.Next(1, 100);
                listBox1.Items.Add(sayı.ToString());
            }
        }
        private void btnforTekrarsız_Click(object sender, EventArgs e)
        {
            başlangıçzamanı = DateTime.Now;
            for (int i = 0; i < listBox1.Items.Count - 1; i++)
            {
                for (int j = listBox1.Items.Count - 1; j >= i + 1; j += -1)
                {
                    if (listBox1.Items[i].ToString() == listBox1.Items[j].ToString())                    
                        listBox1.Items.RemoveAt(j);                    
                }
            }
            bitiş = DateTime.Now;
            fark = bitiş.Subtract(başlangıçzamanı);
            lblForSonuc.Text= fark.TotalSeconds.ToString()+" sn";
        }
        private void btnlistTekrarsiz_Click(object sender, EventArgs e)
        {
            başlangıçzamanı = DateTime.Now;
            List<string> liste = listBox1.Items.OfType<string>().ToList();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(liste.Distinct().ToArray());
            bitiş = DateTime.Now;
            fark = bitiş.Subtract(başlangıçzamanı);
            lbListSonuc.Text=fark.TotalSeconds.ToString() + " sn";
        }        
    }
}
