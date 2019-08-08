using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace Form_CloseReason
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                Process.Start("shutdown", "-a");
                MessageBox.Show("Bilgisayarı Kapatma İşlemi İptal Edildi");
            }
        }
    }
}
