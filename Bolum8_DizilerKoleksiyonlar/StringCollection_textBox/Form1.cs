using System;
using System.Collections.Specialized;
using System.Windows.Forms;
namespace StringCollection_textBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            StringCollection sc = new StringCollection();
            foreach (string satırlar in textBox1.Lines)
            {            
               sc.Add(satırlar);
            }
            MessageBox.Show(sc[0]);
        }
    }
}
