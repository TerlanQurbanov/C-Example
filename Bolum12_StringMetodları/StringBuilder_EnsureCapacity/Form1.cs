using System;
using System.Text;
using System.Windows.Forms;
namespace StringBuilder_EnsureCapacity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string yazi = "VB.Net, C#. Net, Visual C++ .Net, F#";
            StringBuilder sb = new StringBuilder();
            sb.Append(yazi.ToString());
            MessageBox.Show("StringBuilder'ın Kapasitesi= " +
                             sb.Capacity);
            sb.EnsureCapacity(50);
            MessageBox.Show("StringBuilder'ın Yeni Kapasitesi= " +
                             sb.Capacity);
            textBox1.Text = sb.ToString();           
        }
    }
}
