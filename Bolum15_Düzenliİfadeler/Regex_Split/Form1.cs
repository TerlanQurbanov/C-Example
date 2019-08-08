using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Regex_Split
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            byte i;
            string[] dizi = Regex.Split(txticerik.Text, ",");
            for (i = 0; i <= dizi.Length - 1; i++)            
                listBox1.Items.Add(dizi[i]);            
        }
    }
}
