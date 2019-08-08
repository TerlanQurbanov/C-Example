using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Excel_onizleme_yazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Excel.Application ExcelApp = new Excel.Application();
        private void btn_yaziaktar_Click(object sender, EventArgs e)
        {
            ExcelApp.Workbooks.Add();
            ExcelApp.Visible = true;
            ExcelApp.Worksheets[1].Activate();
            ExcelApp.Cells[1, 1].value = (DateTime.Now).
                ToString("MMMM-d-yyyy hh:mm:ss");
            ExcelApp.Cells[1, 1].NumberFormat = "MMMM d yyyy";
            ExcelApp.Cells[1, 2].value = "54321";
            ExcelApp.Cells[1, 2].NumberFormat = "### ###";
            ExcelApp.Cells[1, 3].value = "543,21";
            ExcelApp.Cells[1, 3].NumberFormat = "(#,##0.00)";
        }
        private void btn_baskı_onizleme_Click(object sender, EventArgs e)
        {
            ExcelApp.ActiveSheet.PrintPreview();
        }
        private void btn_yazdır_Click(object sender, EventArgs e)
        {
            ExcelApp.ActiveSheet.PageSetup.PrintArea = "$A$1:$B$3";
            ExcelApp.ActiveSheet.PageSetup.PrintTitleRows = "";
            ExcelApp.ActiveSheet.PageSetup.PrintTitleColumns = "";
            ExcelApp.ActiveSheet.PageSetup.PrintHeadings = false;
            ExcelApp.ActiveSheet.PageSetup.PrintGridLines = false;
            ExcelApp.ActiveSheet.PageSetup.PrintQuality = 600;
            ExcelApp.ActiveSheet.PrintOut();
        }
    }
}
