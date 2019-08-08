using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace listBox_Sırala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i, sayi;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= 10; i++)
            {
                sayi = Convert.ToInt32(Interaction.InputBox
                                (i + ". sayıyı giriniz."));
                listBox1.Items.Add(sayi);
            }
        }
        private void btnSırala_Click(object sender, EventArgs e)
        {
            int l, m;

            for (l = 0; l <= 9; l++)
            {
                for (m = l + 1; m <= 9; m++)
                {
                    if (Int32.Parse(listBox1.Items[l].ToString()) >
                        Int32.Parse(listBox1.Items[m].ToString()))
                    {
                        int aradeger =
                            Int32.Parse(listBox1.Items[l].ToString());
                        listBox1.Items[l] = listBox1.Items[m];
                        listBox1.Items[m] = aradeger;
                    }
                }
            }
        }
    }
}
