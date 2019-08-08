using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Excel_Secme_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Excel.Application ExcelApp = new Excel.Application();
        private void Form1_Load(object sender, EventArgs e)
        {
            ExcelApp.Workbooks.Add();
            ExcelApp.Visible = true;
            ExcelApp.Worksheets[1].Activate();
            //A1 ve B1 hücrelerine değer yazıyoruz 
            ExcelApp.Cells[1, 1].value = "1.değer";
            ExcelApp.Cells[1, 2].value = "2.değer";
            //Hücre isimlendirmede diğer bir yöntemde range nesnesidir  
            ExcelApp.Cells.Range["$C$1"].Value = "Deneme";
        }
        private void btnSatirSec_Click(object sender, EventArgs e)
        {
            ExcelApp.Worksheets[1].Activate();
            ExcelApp.Rows["1:1"].Select();
        }
        private void btnSutunSec_Click(object sender, EventArgs e)
        {
            ExcelApp.Worksheets[1].Activate();
            ExcelApp.Columns["C"].Select();
        }
        private void btnHucreSec_Click(object sender, EventArgs e)
        {
            ExcelApp.Worksheets[1].Activate();
            ExcelApp.Cells.Range["$C$1"].Select();
        }
    }
}
