using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_KeyPress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte i;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            i++;
            if (e.KeyChar == 27) MessageBox.Show(i - 1 + " tuş tıklandı");
        }
    }
}
