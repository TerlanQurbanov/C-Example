using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textBox_AppendText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int karakteradedi = 0;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (karakteradedi>=10)
            {
            if (karakteradedi % (10) == 0)
                textBox1.AppendText(Environment.NewLine);
            }
            karakteradedi = karakteradedi + 1;
        }
    }
}
