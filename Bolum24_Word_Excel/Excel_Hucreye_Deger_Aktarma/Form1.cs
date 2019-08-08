using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Excel_Hucreye_Deger_Aktarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Workbooks.Add();
            ExcelApp.Visible = true;
            ExcelApp.Worksheets[1].Activate();
            ExcelApp.Cells[1, 1].value = "Deneme1";
            ExcelApp.Cells[1, 1].Font.Name = "Verdana";
            //A1 hücresindeki yazının yazı boyutunu 8 olarak değiştiiyoruz
            ExcelApp.Cells[1, 1].Font.Size = 8;
            ExcelApp.Cells[1, 1].Font.color =
                System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
            ExcelApp.Cells[1, 2].value = "Deneme2";
            ExcelApp.Cells[1, 3].value = "Deneme3";
            ExcelApp.Cells[1, 2].font.bold = true;
            ExcelApp.Cells[1, 2].Interior.ColorIndex = 3;
            ExcelApp.Cells[1, 3].Interior.Color =
                System.Drawing.Color.FromArgb(0, 0, 255);
        }
    }
}
