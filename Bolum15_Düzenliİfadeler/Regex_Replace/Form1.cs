using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Regex_Replace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txticerik.Text, "^\\s*$"))            
                MessageBox.Show("Text kutusu boş");            
            else
            {
                Regex regex = new Regex(txtAranan.Text);
                txticerik.Text = regex.Replace(txticerik.Text,
                                    txtDegistirilecek.Text);
            }
        }
    }
}
