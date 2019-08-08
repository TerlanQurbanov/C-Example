using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word; 
namespace word_belge_ac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBelgeAc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Belge seçiniz...";
            openFileDialog1.Filter =
                "Ofis 97-2003 Belgeleri (*.doc)|*.doc|Ofis 2007-2010 Belgeleri (*.docx)|*.docx";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                MessageBox.Show("Dosya seçilmedi");
            else
            {
                Word.Application WordApp = new Word.Application();
                Word.Document WordDoc = new Word.Document();
                WordDoc = WordApp.Documents.Open(openFileDialog1.FileName);
                WordApp.Visible = true;
            }
        }
    }
}
