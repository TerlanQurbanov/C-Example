using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_OwnedForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form ownedForm1 = new Form();
        private void btnOwnedFormEkle_Click(object sender, EventArgs e)
        {
            this.AddOwnedForm(ownedForm1);
            ownedForm1.Show();
        }

        private void btnOwnedFormSil_Click(object sender, EventArgs e)
        {
            this.RemoveOwnedForm(ownedForm1);
        }
    }
}
