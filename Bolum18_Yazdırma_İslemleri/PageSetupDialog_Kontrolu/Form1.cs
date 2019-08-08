using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageSetupDialog_Kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "dosya seç";
            openFileDialog1.Filter = "Word belgeleri (*.doc) |*.doc";
            openFileDialog1.Title = "Lütfen Bir Word Belgesi Seçin";
            DialogResult basilan_tus;
            basilan_tus = openFileDialog1.ShowDialog();
            if (basilan_tus == DialogResult.OK)
                txtDosyaAdı.Text = openFileDialog1.FileName;
        }

        private void btnSayfaAyari_Click(object sender, EventArgs e)
        {
          pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;            
          pageSetupDialog1.AllowMargins = false;
           if (pageSetupDialog1.ShowDialog() == DialogResult.OK) 
          {
              printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings; 
              printDocument1.Print(); 
          } 
        }
    }
}
