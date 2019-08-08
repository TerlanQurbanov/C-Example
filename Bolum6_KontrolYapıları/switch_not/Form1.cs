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
namespace switch_not
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
            switch (notu)
            {
                case 0:
                    {
                        MessageBox.Show("Kaldınız.");
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Kaldınız.");
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Geçtiniz.");
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Geçtiniz.");
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show("Geçtiniz.");
                        break;
                    }
                case 5:
                    {
                        MessageBox.Show("Geçtiniz.");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Yanlış Not Girdiniz.");
                        break;
                    }
            }
        }
    }
}
