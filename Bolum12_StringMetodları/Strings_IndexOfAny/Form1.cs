using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_IndexOfAny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnislemyap_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;
            int index = deger.IndexOfAny(new char[] { ':', '\\', '.' });
            if (index == -1)
                MessageBox.Show("Web site adresi geçerli değil");
            else
                MessageBox.Show("Web site adresi geçerli");
        }
    }
}
