using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace word_yazi_ekleme_range
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
            WordDoc.Range().InsertAfter(textBox1.Text);
            //WordDoc.Range().InsertBefore(textBox1.Text);
            WordApp.Visible = true;
        }
    }
}
