using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace not_5likSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte notu;
            notu = Convert.ToByte(Interaction.InputBox("Notunuzu girin"));
            if (notu < 25)
            {
                MessageBox.Show("Notunuz 0");
            }
            else if (notu < 45)
            {
                MessageBox.Show("Notunuz 1");
            }
            else if (notu < 55)
            {
                MessageBox.Show("Notunuz 2");
            }
            else if (notu < 70)
            {
                MessageBox.Show("Notunuz 3");
            }
            else if (notu < 85)
            {
                MessageBox.Show("Notunuz 4");
            }
            else if (notu <= 100)
            {
                MessageBox.Show("Notunuz 5");
            }
            else
            {
                MessageBox.Show("Yanlış Not Girdiniz");
            }

        }
    }
}
