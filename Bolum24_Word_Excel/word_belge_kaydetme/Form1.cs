using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace word_belge_kaydetme
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
            try
            {
                WordDoc.Close();
                WordApp.Quit();

                WordDoc = null;
                WordApp = null;
            }
            catch
            {
                MessageBox.Show("Önce belge açmanız gerekiyor");
                return;
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                WordDoc.Save();
                //WordDoc.SaveAs(Application.StartupPath + "\\deneme.doc"); 
            }
            catch
            {
                MessageBox.Show("Önce belge açmanız gerekiyor");
                return;
            }
        }
    }
}
