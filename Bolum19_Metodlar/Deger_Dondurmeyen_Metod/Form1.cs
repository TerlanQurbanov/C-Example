using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deger_Dondurmeyen_Metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Renk_Degistir()
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
        private void button1_Click(object sender, EventArgs e)
        {
            Renk_Degistir();
        }
    }
}
