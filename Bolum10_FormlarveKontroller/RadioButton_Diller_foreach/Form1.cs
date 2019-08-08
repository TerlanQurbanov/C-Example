using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_Diller_foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            foreach (Control radio in groupBox1.Controls)
            {
                RadioButton rdb = (RadioButton)(radio);
                if (rdb.Checked) MessageBox.Show
                        ("En çok kullandığınız dil " + rdb.Text);
            }
        }
    }
}
