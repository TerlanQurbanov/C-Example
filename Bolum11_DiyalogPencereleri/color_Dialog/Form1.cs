using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            DialogResult basilan_tus;
            basilan_tus = colorDialog1.ShowDialog();
            if (basilan_tus == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }
    }
}
