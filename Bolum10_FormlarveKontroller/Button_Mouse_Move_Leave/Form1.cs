using System;
using System.Windows.Forms;

namespace Button_Mouse_Move_Leave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Drawing.Color renk;
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = renk;
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.Color.DarkGray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renk = button1.BackColor;
        }
    }
}
