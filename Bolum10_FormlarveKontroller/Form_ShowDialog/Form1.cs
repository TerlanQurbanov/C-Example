using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ShowDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDialog diyalog_formu = new frmDialog();
            diyalog_formu.label1.Text = "Silmek İstediğinize Emin misiniz?";
            diyalog_formu.ShowDialog();
            if (diyalog_formu.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Dosyalar Silindi");
            }
            diyalog_formu.Dispose();
        }
    }
}
