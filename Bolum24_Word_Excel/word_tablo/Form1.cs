using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace word_tablo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Word.Application WordApp = new Word.Application();
        Word.Document WordDoc = new Word.Document();
        private void btntabloekle_Click(object sender, EventArgs e)
        {
            WordApp.Visible = true;
            //5 satır 2 sütun genişliğinde tablo oluşturuyoruz
            WordDoc.Tables.Add(WordApp.Selection.Range, 5, 2);

            //Belgeyi sonuna kadar seçiyoruz
            WordApp.Selection.EndKey(Word.WdUnits.wdStory);
            //Seçim tipini paragraf olarak belirliyoruz
            WordApp.Selection.TypeParagraph();

            WordDoc.Range().Tables[1].Columns[1].SetWidth(120, 0);
            WordDoc.Range().Tables[1].Columns[2].SetWidth(170, 0);

            //Tablonun ilk satırını parlak gri yapıyoruz
            WordDoc.Range().Tables[1].Rows[1].Cells.Shading.
              BackgroundPatternColorIndex = Word.WdColorIndex.wdGray50;

            //İlk satırı koyu yapıyoruz.
            WordDoc.Range().Tables[1].Rows[1].Range.Bold = 1;

            //(1,1) hücresini ortalıyoruz
            WordDoc.Range().Tables[1].Cell(1, 1).Range.Paragraphs.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;

            //1. satır 1. sütun
            WordDoc.Range().Tables[1].Cell(1, 1).Range.InsertAfter("Sınıf");
            WordDoc.Range().Tables[1].Cell(1, 2).Range.InsertAfter("Dal");
            WordDoc.Range().Tables[1].Cell(2, 1).Range.InsertAfter("T11A");
            WordDoc.Range().Tables[1].Cell(2, 2).Range.InsertAfter("Veri Tabanı Programcılığı");
            WordDoc.Range().Tables[1].Cell(3, 1).Range.InsertAfter("A11A");
            WordDoc.Range().Tables[1].Cell(3, 2).Range.InsertAfter("Web Programcılığı");
            WordDoc.Range().Tables[1].Cell(4, 1).Range.InsertAfter("E11A");
            WordDoc.Range().Tables[1].Cell(4, 2).Range.InsertAfter("Donanım Teknik Servis");
            WordDoc.Range().Tables[1].Cell(5, 1).Range.InsertAfter("E11B");
            WordDoc.Range().Tables[1].Cell(5, 2).Range.InsertAfter("Ağ İşletmenliği");          

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
