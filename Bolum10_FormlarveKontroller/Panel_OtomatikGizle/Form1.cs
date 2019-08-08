using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_OtomatikGizle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int konum;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Left = konum;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            konum = panel1.Left;
            panel1.Left = panel1.Left - 90;
            //panel1.Dock = DockStyle.Right            
        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Left = konum - 90;
        }
    }
}
