using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event_handler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void sorgula(object sender, KeyEventArgs e)
        {
            if (txtKullanıcıAdı.Text == "volkan" & txtSifre.Text == "123")
                MessageBox.Show("Giriş yapabilirsiniz");
            else
                MessageBox.Show("Giriş yapamazsınız");
        }
        private void txtKullanıcıAdı_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                this.txtKullanıcıAdı.KeyDown += new
                    System.Windows.Forms.KeyEventHandler(this.sorgula);
        }
        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                this.txtSifre.KeyDown += new
                    System.Windows.Forms.KeyEventHandler(this.sorgula);

        }
    }
}
