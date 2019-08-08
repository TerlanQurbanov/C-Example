using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Kapanis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Print("FormClosing Olayı");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.Print("FormClosed Olayı");
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Debug.Print("Deactivate Olayı");
        }
    }
}
