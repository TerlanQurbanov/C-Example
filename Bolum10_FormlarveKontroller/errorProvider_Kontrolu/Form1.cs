using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace errorProvider_Kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean rakamvar;
        int rakam;
        private void txtAdSoyad_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            rakamvar = int.TryParse(txtAdSoyad.Text, out rakam);
            if (txtAdSoyad.Text == "")
            {
                errorProvider1.SetError(txtAdSoyad, "Ad Soyad boş bırakılamaz");
            }
            else
            {
                if (rakamvar == true)
                    errorProvider1.SetError(txtAdSoyad, "Ad Soyad alanına rakam girilemez");
            }  
        }
        private void txtNumara_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            rakamvar = int.TryParse(txtNumara.Text, out rakam);
            if (txtNumara.Text == "")
            {
                errorProvider1.SetError(txtNumara, "Numara boş bırakılamaz");
            }
            else
            {
                if (rakamvar == false)
                    errorProvider1.SetError(txtNumara, "Numara alanına harf girilemez");
            } 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rakamvar = false; 
        }
    }
}
