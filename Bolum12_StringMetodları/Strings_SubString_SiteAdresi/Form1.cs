using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_SubString_SiteAdresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubString_Click(object sender, EventArgs e)
        {
            int pozisyon;
            string cumle;
            cumle = textBox1.Text;
            pozisyon = (textBox1.Text.IndexOf(".") + 1);
            MessageBox.Show(cumle.Substring(pozisyon,
                               cumle.Length - pozisyon));

        }
    }
}
