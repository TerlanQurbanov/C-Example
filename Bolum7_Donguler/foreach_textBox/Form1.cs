using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreach_textBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control nesne in this.Controls)
            {
                if ((nesne) is TextBox)
                {
                    nesne.Text = "";
                    nesne.BackColor = Color.SteelBlue;
                    nesne.ForeColor = Color.Red;
                }
            }       

        }
    }
}
