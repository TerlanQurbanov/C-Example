using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace BeginPrint_EndPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Font printFont;
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += pd_PrintPage;
            pd.BeginPrint += pd_BeginPrint;
            pd.EndPrint += pd_EndPrint;
        }
        private void pd_EndPrint(object sender, PrintEventArgs e)
        {
            MessageBox.Show("Yazdırma işlemi bitti");
            printFont.Dispose();
            printFont = null;
        }
        private void pd_BeginPrint(object sender, PrintEventArgs e)
        {
            MessageBox.Show("Yazdırma işlemi başladı");
            printFont = new Font("Times New Roman", 12);
        }

        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text,
                printFont, Brushes.Black, 0, 0);
        }
        

    }
}
