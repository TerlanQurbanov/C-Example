using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Params_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        snf_aktif_pasif nsn_aktif_pasif = new snf_aktif_pasif();
        private void Form1_Load(object sender, EventArgs e)
        {
            nsn_aktif_pasif.mtd_aktif(btnYeni);
            nsn_aktif_pasif.mtd_pasif(btnGuncelle, btniptal,
                btnKaydet, btnSil);
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            nsn_aktif_pasif.mtd_aktif(btnKaydet, btniptal);
            nsn_aktif_pasif.mtd_pasif(btnYeni, btnGuncelle, btnSil);
        }
    }
}
