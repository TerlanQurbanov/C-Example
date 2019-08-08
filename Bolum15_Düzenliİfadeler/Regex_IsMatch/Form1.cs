using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Regex_IsMatch
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
                MessageBox.Show("Text kutusu boş değil");           

        }
    }
}
