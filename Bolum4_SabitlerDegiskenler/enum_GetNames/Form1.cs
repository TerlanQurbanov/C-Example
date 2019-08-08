using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enum_GetNames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [Flags()]
        enum uzmanlık
        {
            VBNet = 1,
            PHP = 2,
            ASPNet = 4,
            CSharp = 8
        }
        private void btnAktar_Click(object sender, EventArgs e)
        {
            foreach (string uzmanlıkalanı in Enum.GetNames(typeof(uzmanlık)))
            {
                listBox1.Items.Add(uzmanlıkalanı);
            }
        }
    }
}
