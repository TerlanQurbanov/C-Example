using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Regex_Matches_Count
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txticerik.Text, "^\\s*$"))            
                MessageBox.Show("Text kutusu boş");            
            else            
                MessageBox.Show(Regex.Matches(txticerik.Text, txtaranan.Text,
                            RegexOptions.Multiline).Count + " adet bulundu");            
        }
    }
}
