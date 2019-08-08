using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace word_onizleme_yazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Word.Application WordApp = new Word.Application();
        Word.Document WordDoc = new Word.Document();
        private void btnyaziekle_Click(object sender, EventArgs e)
        {
            WordDoc = WordApp.Documents.Add();
            WordApp.Visible = true;

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                WordDoc.Paragraphs[1].Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;

                WordApp.Selection.Font.Name = "Times New Roman";
                WordApp.Selection.Font.Size = 14;
                WordApp.Selection.Font.Underline =
                    Word.WdUnderline.wdUnderlineSingle;
                WordApp.Selection.BoldRun();

                //Textbox içerisindeki yazıyı ekliyoruz.
                WordApp.Selection.TypeText(textBox1.Text);
                //paragrafı seçiyoruz
                WordApp.Selection.TypeParagraph();
                //yazının kalınlık özelliğini kaldırıyoruz
                WordApp.Selection.BoldRun();
                //Textbox içerisindeki yazıyı yeniden ekliyoruz.
                WordApp.Selection.TypeText(textBox1.Text);
            }
        }

        private void btn_baski_onizleme_Click(object sender, EventArgs e)
        {
            try
            {
                WordDoc.PrintPreview();
            }
            catch
            {
                MessageBox.Show("Önce belge açmanız gerekiyor");
                return;
            }
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            try
            {
                WordDoc.PrintOut();
            }
            catch
            {
                MessageBox.Show("Önce belge açmanız gerekiyor");
                return;
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
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
    }
}
