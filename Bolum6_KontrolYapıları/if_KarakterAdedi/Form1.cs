using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_KarakterAdedi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Int32 karakteradedi;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (karakteradedi >0)
            {
            if (karakteradedi % Convert.ToInt32(txtKarakter.Text) == 0)
                textBox1.AppendText(Environment.NewLine);
            }
            karakteradedi = karakteradedi + 1;
        }
    }
}
