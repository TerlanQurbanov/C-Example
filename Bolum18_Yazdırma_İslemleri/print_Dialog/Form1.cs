using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
namespace print_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Font printFont;
        StreamReader sr;        
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "dosya seç";
            openFileDialog1.Filter = "Word belgeleri (*.doc) |*.doc";
            openFileDialog1.Title = "Lütfen Bir Word Belgesi Seçin";
            DialogResult basilan_tus;
            basilan_tus = openFileDialog1.ShowDialog();
            if (basilan_tus == DialogResult.OK)
                txtDosyaAdı.Text = openFileDialog1.FileName;
        }
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            printFont = new Font("Times New Roman", 12);
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            pd.EndPrint += pd_EndPrint;
            sr = new StreamReader(txtDosyaAdı.Text);

            PrintDialog dlgPrint = new PrintDialog();
            dlgPrint.Document = pd;

            if (dlgPrint.ShowDialog() == DialogResult.OK)            
                pd.Print();            
        }
        private void pd_EndPrint(object sender, PrintEventArgs e)
        {
            printFont.Dispose();
            printFont = null;
            sr.Close();
        }
        private void pd_PrintPage(Object sender, PrintPageEventArgs e)
        {
            Single SolMargin = e.MarginBounds.Left;
            Single UstMargin = e.MarginBounds.Top;
            int sayi = 0;
            string satir = null;
            Single yPozisyonu = 0;
            Single SayfaBasiSatirAdedi = e.MarginBounds.Height /
                printFont.GetHeight(e.Graphics);

            while (sayi < SayfaBasiSatirAdedi &&
                ((satir = sr.ReadLine()) != null))
            {
                yPozisyonu = UstMargin + (sayi *
                    printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(satir, printFont, Brushes.Black,
                    SolMargin, yPozisyonu, new StringFormat());
                sayi++;
            }

            if (satir != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }
    }
}
