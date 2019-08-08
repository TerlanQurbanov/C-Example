using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Form_Acilis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Debug.Print("Activated Olayı");
        }
        private void Form1_BindingContextChanged(object sender, EventArgs e)
        {
            Debug.Print("BindingContextChanged Olayı");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.Print("Load Olayı");
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Debug.Print("Paint Olayı");
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Debug.Print("Shown Olayı");
        }
        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            Debug.Print("VisibleChanged Olayı");
        }
        private void Form1_Validated(object sender, EventArgs e)
        {
            Debug.Print("Validated Olayı");
        }       
    }
}
