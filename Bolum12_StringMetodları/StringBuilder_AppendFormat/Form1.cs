using System;
using System.Text;
using System.Windows.Forms;
namespace StringBuilder_AppendFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnislem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0:hh:mm:ss}", DateTime.Now);
            sb.AppendLine();
            sb.AppendFormat("{0:HH:mm:ss}", DateTime.Now);
            sb.AppendLine();
            sb.AppendFormat("{0:dd MM yyyy}", DateTime.Now);
            sb.AppendLine();
            sb.AppendFormat("{0:dd MMMM yyyy}", DateTime.Now);
            sb.AppendLine();
            sb.AppendFormat("{0:HH:mm:ss dd MMMM yyyy}", DateTime.Now);
            textBox1.AppendText(sb.ToString());
        }
    }
}
