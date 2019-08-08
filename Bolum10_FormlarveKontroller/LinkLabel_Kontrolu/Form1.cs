using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkLabel_Kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:volkanaktas@yahoo.com?subject=Soru Bankasi");
            linkLabel2.LinkVisited = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, 19, "www.volkanaktas.com");
            linkLabel2.Links.Add(0, 24, "volkanaktas@yahoo.com");
        }
    }
}
