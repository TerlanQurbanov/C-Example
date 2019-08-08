using System;
using System.Windows.Forms;
using aktif_pasif_dll;
namespace akt_pas_dll_kullan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            snf_aktif_pasif nsn_akt_pas = new snf_aktif_pasif();
            nsn_akt_pas.mtd_aktif(btnYeni);
            nsn_akt_pas.mtd_pasif(btnGuncelle, btniptal,
                btnKaydet, btnSil);
        }
    }
}
