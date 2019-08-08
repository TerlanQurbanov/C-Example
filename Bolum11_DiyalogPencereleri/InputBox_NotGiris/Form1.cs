using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace InputBox_NotGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnislemyap_Click(object sender, EventArgs e)
        {
            byte not1 = Convert.ToByte(Interaction.InputBox("1. Notu Girin",
              "Not Girişi", "100", 10, 10));
            byte not2 = Convert.ToByte(Interaction.InputBox("2. Notu Girin",
                        "Not Girişi", "100", 10, 10));
            MessageBox.Show("Ortalama= " + (not1 + not2) / 2);
        }
    }
}
