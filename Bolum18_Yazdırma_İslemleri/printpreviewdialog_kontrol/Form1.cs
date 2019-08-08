using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
namespace printpreviewdialog_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        string icerik;
        PrintDocument printDocument1 = new PrintDocument();
        string stringToPrint;
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            DialogResult basilan_tus;
            basilan_tus = openFileDialog1.ShowDialog();
            if (basilan_tus == DialogResult.OK)
                txtDosyaAdı.Text = openFileDialog1.FileName;        }

        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(txtDosyaAdı.Text);
            string dosya_adı = fileInfo.Name;
            string dosya_yolu = fileInfo.DirectoryName;
            using (FileStream stream = new FileStream(dosya_yolu +"\\"+ dosya_adı, FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                icerik = reader.ReadToEnd();
            }
            stringToPrint = icerik;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int karaktersayısı = 0;
            int satırsayısı = 0;

            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out karaktersayısı, out satırsayısı);

            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic);

            stringToPrint = stringToPrint.Substring(karaktersayısı);

            e.HasMorePages = (stringToPrint.Length > 0);
            if (!e.HasMorePages)
                stringToPrint = icerik;
        }      
    }
}
