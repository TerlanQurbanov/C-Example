using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace word_yazi_ekleme_sentences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnyaziekle_Click(object sender, EventArgs e)
        {
            Word.Application WordApp = new Word.Application();
            Word.Document WordDoc = new Word.Document();
            WordDoc = WordApp.Documents.Add();
            WordApp.Visible = true;

            int cumlesayisi = WordDoc.Sentences.Count;
            if (cumlesayisi > 0)
                WordDoc.Sentences[cumlesayisi].Text = textBox1.Text;
            else
                WordDoc.Sentences[1].Text = textBox1.Text; 
        }
    }
}
