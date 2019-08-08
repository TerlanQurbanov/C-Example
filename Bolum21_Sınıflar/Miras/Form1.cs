using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            Miras.snf_mirascı nsn_mesaj = new Miras.snf_mirascı();
            nsn_mesaj.mtd_gelismis_mesaj("c sharp .net", true);
        }   
    }
}
