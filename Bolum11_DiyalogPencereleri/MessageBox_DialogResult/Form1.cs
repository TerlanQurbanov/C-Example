using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox_DialogResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult basilan_tus;
            basilan_tus = MessageBox.Show("Çıkmak istediğinize emin misiniz?",
                            "Soru", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);
            if (basilan_tus == DialogResult.OK) Application.Exit();
        }
    }
}
