using System;
using System.Windows.Forms;
namespace Formlar_Arası_Gecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonrakiForm_Click(object sender, EventArgs e)
        {
            //this.Hide(); 
            //this.Visible = false; 
            Form2 frm2 = new Form2();
            //frm2.Show();
            frm2.ShowDialog();
        }      
    }
}
