using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metod_Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Ortalama(int yazılı1, int yazılı2, int sozlu)
        {
            return (yazılı1 + yazılı2 + sozlu) / 3;
        }
        private int Ortalama(int yazılı1, int yazılı2, int sozlu, int odev)
        {
            return (yazılı1 + yazılı2 + sozlu + odev) / 4;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (txtOdev.Text == "")
            {                
                MessageBox.Show("Ortalama= " + 
                    Ortalama(Convert.ToInt32(txtYazılı1.Text),
                    Convert.ToInt32(txtYazılı2.Text), 
                    Convert.ToInt32(txtSozlu.Text)));
            }
            else
                MessageBox.Show("Ortalama= " + 
                    Ortalama(Convert.ToInt32(txtYazılı1.Text), 
                    Convert.ToInt32(txtYazılı2.Text), 
                    Convert.ToInt32(txtSozlu.Text), 
                    Convert.ToInt32(txtOdev.Text)));
            }
        }
}

