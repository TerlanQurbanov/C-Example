using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Compare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string yazi1 = textBox1.Text;
            string yazi2 = textBox2.Text;
            if (string.Compare(yazi1, yazi2,
                    //StringComparison.CurrentCulture) == 0)
                    //StringComparison.CurrentCultureIgnoreCase) == 0)
                    //StringComparison.Ordinal) == 0)
                    StringComparison.InvariantCultureIgnoreCase)==0)
            {
                MessageBox.Show("1.Cümle 2.Cümleye Eşittir.");
            }
            else if (string.Compare(yazi1, yazi2,
                    //StringComparison.CurrentCulture) < 0)
                //StringComparison.CurrentCultureIgnoreCase) == 0)
                //StringComparison.Ordinal) < 0)
                StringComparison.InvariantCultureIgnoreCase) == 0)
            {
                MessageBox.Show("1.Cümle 2.Cümleden Kısadır.");
            }
            else           
                MessageBox.Show("1.Cümle 2.Cümleden Uzundur.");            

        }
    }
}
