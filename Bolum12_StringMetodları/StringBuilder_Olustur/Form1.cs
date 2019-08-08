using System;
using System.Text;
using System.Windows.Forms;
namespace StringBuilder_Olustur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string yazi = "C Sharp .NET";
            StringBuilder sb = new StringBuilder(yazi);
            MessageBox.Show(sb.ToString());
        }
    }
}
