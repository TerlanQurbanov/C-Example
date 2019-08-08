using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deger_Donduren_Metod_Params
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public byte NotHesapla(byte yazılı, params byte[] sozlu)
        {
            byte puan = 0;
            int notu = 0;
            byte i = 0;
            int sozlutoplam = 0;

            for (i = 0; i <= sozlu.Length - 1; i++)
                sozlutoplam += sozlu[i];

            if (i > 0)
                notu = (yazılı + sozlutoplam) / (i + 1);

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
            MessageBox.Show(NotHesapla(45, 80, 90, 100).ToString());
        }
    }
}
