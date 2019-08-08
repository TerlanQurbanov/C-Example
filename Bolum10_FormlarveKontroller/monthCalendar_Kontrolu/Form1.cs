using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monthCalendar_Kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.ShowToday = false;
            monthCalendar1.ShowTodayCircle = false;
            monthCalendar1.AddBoldedDate(DateTime.Parse("2012/10/4"));
            monthCalendar1.AddBoldedDate(DateTime.Parse("2012/10/5"));
            monthCalendar1.UpdateBoldedDates();
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("Seçili Tarih: " +
          monthCalendar1.SelectionRange.Start.ToString("dd MMMM yyyy"));

        }
    }
}
