using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace excel_kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Excel.Application ExcelApp = new Excel.Application();
        private void btnYeni_Click(object sender, EventArgs e)
        {
            ExcelApp.Workbooks.Add();
            ExcelApp.Visible = true;
            ExcelApp.Worksheets[1].Activate();
            ExcelApp.Cells[1, 1].value = "Deneme";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelApp.Save();
            }
            catch
            {
                MessageBox.Show("Önce belge açmanız gerekiyor");
                return;
            }
        }
        private void btnFarkliKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelApp.GetSaveAsFilename();
            }
            catch
            {
                MessageBox.Show("Önce belge açmanız gerekiyor");
                return;
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelApp.Workbooks.Close();
                ExcelApp.Quit();
                ExcelApp = null;
                System.GC.Collect();
            }
            catch
            {
                MessageBox.Show("Önce belge açmanız gerekiyor");
                return;
            }
        }
    }
}
