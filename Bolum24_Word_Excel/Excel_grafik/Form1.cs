using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Excel_grafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            string[] isimler = new string[6];
            byte[] yaslar = new byte[6];

            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Workbooks.Add();
            ExcelApp.Visible = true;

            ExcelApp.Worksheets[1].Activate();

            ExcelApp.Cells[1, 1].value = "İsimler";
            ExcelApp.Cells[1, 2].value = "Yaşlar";
            for (int i = 2; i <= lstisim.Items.Count + 1; i++)           
                ExcelApp.Cells[i, 1].value = lstisim.Items[i - 2];            
            for (int j = 2; j <= lstyas.Items.Count + 1; j++)            
                ExcelApp.Cells[j, 2].value = lstyas.Items[j - 2];            

            Excel.Worksheet xlWorkSheet =
                (Excel.Worksheet)ExcelApp.ActiveSheet;
            Excel.ChartObjects xlCharts =
                (Excel.ChartObjects)xlWorkSheet.ChartObjects();
            Excel.ChartObject Chart =
                (Excel.ChartObject)xlCharts.Add(110, 10, 250, 250);
            Excel.Chart chartPage = Chart.Chart;
            Excel.Range chartRange;
            chartRange = xlWorkSheet.get_Range("A2", "B7");
            chartPage.SetSourceData(chartRange);

            chartPage.ChartType = Excel.XlChartType.xl3DColumnClustered;
            chartPage.HasDataTable = true;
        }
    }
}
