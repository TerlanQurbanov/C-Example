using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace excel_yeni_belge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Workbooks.Add();
            ExcelApp.Visible = true;
            ExcelApp.Worksheets[1].Activate();
            ExcelApp.Cells[1, 1].value = "Deneme";
        }
    }
}
