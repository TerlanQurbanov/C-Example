using System;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Graph;
using System.Drawing;
using System.Windows.Forms;

namespace word_grafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            Word.Application WordApp = new Word.Application();
            Word.Document WordDoc = new Word.Document();
            WordApp.Visible = true;
            Word.InlineShape Shape;
            Word.Range WordRng = WordDoc.Bookmarks.
                get_Item("\\endofdoc").Range;
            Shape = WordRng.InlineShapes.AddOLEObject("MSGraph.Chart.8");

            object oChart;
            object oChartApp;
            oChart = Shape.OLEFormat.Object;
            oChartApp = oChart.GetType().InvokeMember("Application",
                BindingFlags.GetProperty, null, oChart, null);

            Chart objChart = (Chart)Shape.OLEFormat.Object;
            objChart.ChartType = XlChartType.xl3DColumnStacked;

            DataSheet ds;
            ds = objChart.Application.DataSheet;
            ds.Columns.Clear();
            ds.Rows.Clear();
            for (int i = 0; i < lstisim.Items.Count; i++)
            {
                ds.Cells[1, 2 + i] = lstisim.Items[i].ToString();
                ds.Cells[2, 2 + i] = lstyas.Items[i].ToString();
            }

            Shape.Width = WordApp.InchesToPoints(4.25f);
            Shape.Height = WordApp.InchesToPoints(3.25f);

            objChart.Application.Update();
            oChartApp.GetType().InvokeMember("Update",
                BindingFlags.InvokeMethod, null, oChartApp, null);
            oChartApp.GetType().InvokeMember("Quit",
                BindingFlags.InvokeMethod, null, oChartApp, null); 

        }
    }
}
