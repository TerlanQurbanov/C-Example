using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace word_belge_acma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Word.Application WordApp = new Word.Application();
        Word.Document WordDoc = new Word.Document();
        private void btnYeniBelge_Click(object sender, EventArgs e)
        {
            WordDoc = WordApp.Documents.Add();
            WordApp.Visible = true;
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            WordDoc.Close();
            WordApp.Quit();

            WordDoc = null;
            WordApp = null;
        }
    }
}
