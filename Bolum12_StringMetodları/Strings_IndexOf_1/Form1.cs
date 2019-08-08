using System;
using System.Windows.Forms;
namespace Strings_IndexOf_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.IndexOf(txtAranacakMetin.Text) == 0))           
                MessageBox.Show("Aranacak değer belirtilmedi");            
            else if (textBox1.Text.IndexOf(txtAranacakMetin.Text) == -1)            
                MessageBox.Show("Aranan değer mevcut değil");            
            else           
                MessageBox.Show("Aranan değer mevcut. Konumu= "
                    + (textBox1.Text.IndexOf(txtAranacakMetin.Text)));
        }
    }
}
