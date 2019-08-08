using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anonymous_metod_mesaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void Del_Metod(string mesaj, string baslık);
        Del_Metod Mesaj = delegate(string mesaj, string baslık)
        {
            MessageBox.Show(baslık, mesaj);
        };
        private void btnMesaj_Click(object sender, EventArgs e)
        {
            Mesaj("Mesaj", "Anonymous Metod Örneği");
        }
    }
}
