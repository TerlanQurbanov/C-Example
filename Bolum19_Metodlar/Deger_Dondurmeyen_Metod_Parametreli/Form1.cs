using System;
using System.Drawing;
using System.Windows.Forms;
namespace Deger_Dondurmeyen_Metod_Parametreli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Renk_Degistir(Control nesne)
        {
            if ((nesne) is TextBox)
            {
                nesne.Text = "";
                nesne.BackColor = Color.SteelBlue;
                nesne.ForeColor = Color.Red;
            }
            else if ((nesne) is Label)
            {
                nesne.BackColor = Color.DimGray;
                nesne.ForeColor = Color.White;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Renk_Degistir(textBox1);
            Renk_Degistir(label1);
        }
    }
}
