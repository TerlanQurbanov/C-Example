﻿using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace textBox_Yazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += pd_PrintPage;
            pd.Print();
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font printFont = new Font("Times New Roman", 12);
            e.Graphics.DrawString(textBox1.Text,
                printFont, Brushes.Black, 0, 0);
            //StringFormat f = new StringFormat(StringFormatFlags.DirectionVertical);
        }        
    }
}
