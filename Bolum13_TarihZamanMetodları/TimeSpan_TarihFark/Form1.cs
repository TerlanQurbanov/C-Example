using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSpan_TarihFark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFark_Click(object sender, EventArgs e)
        {
            DateTime tarih1 = Convert.ToDateTime(txtTarih1.Text);
            DateTime tarih2 = Convert.ToDateTime(txtTarih2.Text);
            TimeSpan ts = tarih1 - tarih2;
            //lblSonuc.Text = ts.Days.ToString();
            lblSonuc.Text = ts.TotalHours.ToString();
        }
    }
}
