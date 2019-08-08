using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_ToUpper_ToLower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            //textBox1.Text = textBox1.Text.ToUpperInvariant();
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
            //textBox1.Text = textBox1.Text.ToLowerInvariant();
        }

      
    }
}
