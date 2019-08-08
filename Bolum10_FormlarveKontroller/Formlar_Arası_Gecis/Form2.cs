using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arası_Gecis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnÖncekiForm_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Visible = true;  
        }
    }
}
