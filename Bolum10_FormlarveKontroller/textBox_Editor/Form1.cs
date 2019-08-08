using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textBox_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Cut();
            }
            else
            {
                MessageBox.Show("Seçili Alan Yok");
            }
        }
        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
            else
            {
                MessageBox.Show("Seçili Alan Yok");
            }
        }
        private void btnYapistir_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }
        private void btnYaziTipi_Click(object sender, EventArgs e)
        {
            if (FontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = FontDialog1.Font;
        }
        private void btnYaziRengi_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = ColorDialog1.Color;
        }
        private void btnKalin_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(Font, FontStyle.Bold);
        }

        private void btnEgik_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(Font, FontStyle.Italic);
        }

        private void btnAltiCizili_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(Font, FontStyle.Underline);
        }
    }
}
