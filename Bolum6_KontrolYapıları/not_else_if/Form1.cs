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
namespace not_else_if
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
            if (notu <= 100)
            {
                if (notu < 45)
                {
                    MessageBox.Show("Kaldınız");
                }
                else if (notu >= 45)
                {
                    MessageBox.Show("Geçtiniz");
                }
            }
            else
            {
                MessageBox.Show("Not 100'den küçük olmalı");
            }
        }
    }
}
