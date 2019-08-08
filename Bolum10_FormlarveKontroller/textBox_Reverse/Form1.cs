using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textBox_Reverse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] str = textBox1.Text.ToCharArray();
            Array.Reverse(str);
            string strReversed = new string(str);
            textBox2.Text = strReversed;
        }
    }
}
