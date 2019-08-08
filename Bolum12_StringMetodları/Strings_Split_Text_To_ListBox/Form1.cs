using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Split_Text_To_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            byte i;
            string[] yazi;
            yazi = textBox1.Text.Split(' ',',');
            for (i = 0; i <= yazi.Length - 1; i++)            
                listBox1.Items.Add(yazi[i].ToString());
        }
    }
}
