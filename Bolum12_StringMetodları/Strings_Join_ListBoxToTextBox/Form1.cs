using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Join_ListBoxToTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            string[] diller = new string[listBox1.Items.Count];
            byte i;

            for (i = 0; i <= listBox1.Items.Count - 1; i++)
                diller[i] = listBox1.Items[i].ToString();
            textBox1.Text = string.Join(",", diller);

        }
    }
}
