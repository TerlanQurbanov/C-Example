using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Excel_Hucreye_Erisim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Belge seçiniz...";
            openFileDialog1.Filter =  "Excel 2003 dosyaları (*.xls)|*.xls|Excel 2007-2010 dosyaları (*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                MessageBox.Show("Dosya seçilmedi");
            else
            {
                Excel.Application ExcelApp = new Excel.Application();
                ExcelApp.Workbooks.Open(openFileDialog1.FileName);
                ExcelApp.Visible = true;

                MessageBox.Show(ExcelApp.Worksheets[1].Range("A2").Value);
                //MessageBox.Show(ExcelApp.Worksheets["Sayfa1"].Range("A2").Value);
                //MessageBox.Show(ExcelApp.Cells.Range["$A$2"].Value);   
                //MessageBox.Show(ExcelApp.ActiveSheet.Range("A2").Value);
                //MessageBox.Show(ExcelApp.Worksheets[1].Cells.Item(2, 1).Value);
                //MessageBox.Show(ExcelApp.Worksheets[1].Cells(2, 1).Value);               
                //MessageBox.Show(ExcelApp.Worksheets[1].Rows(2).Cells(1).Value);               
                //MessageBox.Show(ExcelApp.Worksheets[1].Columns(1).Cells(2).Value);
            }
        }
    }
}
