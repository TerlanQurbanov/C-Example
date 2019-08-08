using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optional_parameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Renk_Degistir(Control nesne, string yazi = "label", Boolean bold = false)
        {
            if ((nesne) is TextBox)
            {
                nesne.Text = "";
                nesne.BackColor = Color.SteelBlue;
                nesne.ForeColor = Color.Red;
                if (bold == true)
                    nesne.Font = new Font(Font, FontStyle.Bold);
            }
            else if ((nesne) is Label)
            {
                nesne.BackColor = Color.DimGray;
                nesne.ForeColor = Color.White;
            }
            nesne.Text = yazi;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Renk_Degistir(label1);
            Renk_Degistir(label1, "Adı Soyadı");
            Renk_Degistir(nesne: textBox1, yazi: "Volkan AKTAŞ", bold: true);
            Renk_Degistir(label2, "Görev Yeri");
            Renk_Degistir(nesne: textBox2, yazi: "MERSİN");
            
        }
    }
}
