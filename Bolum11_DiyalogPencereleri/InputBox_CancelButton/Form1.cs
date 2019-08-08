using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace InputBox_CancelButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnislemyap_Click(object sender, EventArgs e)
        {
            string not1 = Interaction.InputBox("Notu Girin", "Not Girişi",
                "100", 10, 10);
            if (not1.Length == 0)
            {
                System.Environment.Exit(0);
            }
            else
            {
                string not2 = Interaction.InputBox("Notu Girin", "Not Girişi",
                    "100", 10, 10);
                MessageBox.Show("Ortalama= " + (Convert.ToByte(not1) +
                    Convert.ToByte(not2)) / 2);
            }
        }
    }
}
