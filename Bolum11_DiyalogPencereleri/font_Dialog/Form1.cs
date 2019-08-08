using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace font_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazıTipi_Click(object sender, EventArgs e)
        {
            DialogResult basilan_tus;
            basilan_tus = fontDialog1.ShowDialog();
            if (basilan_tus == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }
    }
}
