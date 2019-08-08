using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace print_dialog_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamReader sr;
        Font printFont;
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
            sr = new StreamReader(txtDosyaAdı.Text);
            DialogResult basilan_tus;
            basilan_tus = printDialog1.ShowDialog();
            if (basilan_tus == DialogResult.OK)
                printDocument1.Print();            
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printFont.Dispose();
            printFont = null;
            sr.Close();
        }
    }
}
