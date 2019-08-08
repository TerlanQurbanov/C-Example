using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lambda_toplam_fark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate int Del_Metod(int sayi1, int sayi2);
        private void btnMesaj_Click(object sender, EventArgs e)
        {
            Del_Metod sonuc = (sayi1, sayi2) => sayi1 + sayi2;
            MessageBox.Show(sonuc.Invoke(5, 10).ToString());
        }
    }
}
