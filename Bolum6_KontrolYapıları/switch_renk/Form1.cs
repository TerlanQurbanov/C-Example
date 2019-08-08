using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_renk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            switch (listBox1.Text)
            {
                case "mavi": this.BackColor = Color.Blue; break;
                case "sarı": this.BackColor = Color.Yellow; break;
                case "siyah": this.BackColor = Color.Black; break;
                case "kırmızı": this.BackColor = Color.Red; break;
                case "yeşil": this.BackColor = Color.Green; break;
                case "kahverengi": this.BackColor = Color.Brown; break;
                case "mor": this.BackColor = Color.Purple; break;
                case "gri": this.BackColor = Color.Gray; break;
            }
        }
    }
}
