using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_KeyDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)            
            {
                DialogResult cikis = MessageBox.Show
                  ("Ctrl+C tuşlarına basıldı. Çıkmak istediğinize emin misiniz",
                  "Çıkış", MessageBoxButtons.OKCancel);
                if (cikis == DialogResult.OK) Application.Exit();
            }

        }
    }
}
