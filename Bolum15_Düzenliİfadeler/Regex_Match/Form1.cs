using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Regex_Match
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, "^\\s*$"))            
                MessageBox.Show("Text kutusu boş");            
            else
            {
                string ad = Regex.Match(textBox1.Text, "^Adı:(.*)",
                            RegexOptions.IgnoreCase).Groups[1].Value;
                MessageBox.Show(ad.ToString());
            }
        }
    }
}
