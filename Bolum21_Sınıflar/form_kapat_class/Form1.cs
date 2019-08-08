using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_kapat_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            //snf_form_kapat nsn_kapat = new snf_form_kapat();
            //nsn_kapat.mtd_kapat(this);
            snf_form_kapat.mtd_kapat(this);
        }
    }
}
