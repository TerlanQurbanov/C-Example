using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degisken_Deger_Referans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = "Ana Program tarafından oluşturulan mesaj";
            MessageBox.Show(mesaj);
            //mesajyaz(mesaj);
            mesajyaz(ref mesaj);
            MessageBox.Show(mesaj);
        }
        //private void mesajyaz(string mesaj)
        private void mesajyaz(ref string mesaj)
        {
            mesaj = "Metod tarafından oluşturulan mesaj";
        }

    }
}
