using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_renk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(listBox1.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KnownColor renk = default(KnownColor);
            for (renk = KnownColor.ActiveBorder; renk <= KnownColor.YellowGreen; renk++)
            {
                listBox1.Items.Add(renk);
            }
        }
    }
}
