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
namespace for_faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, sayi, fak=1;            
            sayi = Convert.ToInt32(Interaction.InputBox("Sayıyı Girin"));
            for (i = 1; i <= sayi; i++)
            {
                fak = fak * i;
            }
            MessageBox.Show(sayi + " sayısının faktöriyeli = " + fak);

        }
    }
}
