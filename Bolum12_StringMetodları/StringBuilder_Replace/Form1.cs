using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilder_Replace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder sb = new StringBuilder();
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            sb.AppendLine("Tesadüf yok, hadisat başıboş gelmiyor, intizamsız değillerdir");
            textBox1.Text = sb.ToString();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            sb.Replace(textBox1.Text, textBox1.Text.ToUpper());
            textBox1.Text = sb.ToString();
        }
    }
}
