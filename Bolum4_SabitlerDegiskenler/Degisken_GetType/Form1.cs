using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degisken_GetType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegiskenTipi_Click(object sender, EventArgs e)
        {
            var isim = "Sümeyye AKTAŞ";
            MessageBox.Show(isim.GetType().ToString());

            var yas = 5;
            MessageBox.Show(yas.GetType().ToString());

            var ondalık_sayı = 12.4;
            MessageBox.Show(ondalık_sayı.GetType().ToString());

            var mantıksal_degisken = true;
            MessageBox.Show(mantıksal_degisken.GetType().ToString());

        }
    }
}
