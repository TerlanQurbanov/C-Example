using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Sin_Cos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (rdDerece.Checked == true)
            {
                textBox1.Text = Convert.ToString(Math.Sin
                    ((Convert.ToDouble(Math.PI) / 180) *
                        (Convert.ToDouble(textBox1.Text))));
            }
            else
            {
                textBox1.Text = Convert.ToString(Math.Sin
                    (Convert.ToDouble(textBox1.Text)));
            }
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            if (rdDerece.Checked == true)
            {
                textBox1.Text = Convert.ToString(Math.Cos
                    ((Convert.ToDouble(Math.PI) / 180) *
                        (Convert.ToDouble(textBox1.Text))));
            }
            else
            {
                textBox1.Text = Convert.ToString(Math.Cos
                    (Convert.ToDouble(textBox1.Text)));
            }
        }
    }
}
