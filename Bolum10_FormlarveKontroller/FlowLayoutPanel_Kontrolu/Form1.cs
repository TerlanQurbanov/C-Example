using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowLayoutPanel_Kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnislem_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            //flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.AutoScroll = true;
        }
    }
}
