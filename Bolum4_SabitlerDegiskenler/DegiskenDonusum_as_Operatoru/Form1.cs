using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegiskenDonusum_as_Operatoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayi = 0;
            foreach (Control nesne in this.Controls)
            {
                Button btn = nesne as Button;
                if (btn == null)
                {
                    nesne.BackColor = Color.SteelBlue;
                    nesne.Text = "deneme";
                }
                else
                {
                    nesne.BackColor = Color.Aquamarine;
                    sayi = sayi + 1;
                    nesne.Text = "Buton" + sayi;
                }
            }

        }
    }
}
