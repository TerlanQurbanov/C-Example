using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Now_StandartDateTimeFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            DateTime zaman;
            zaman = DateTime.Now;
            string sonuc;
            sonuc = string.Format("{0:d}", zaman);
            MessageBox.Show(sonuc);
        }
    }
}
