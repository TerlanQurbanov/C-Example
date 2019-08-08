using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pattern_Matching_Type_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            int sayi = 0;
            foreach (Control nesne in this.Controls)
            {
                Button btn = nesne as Button;
                if(btn==null)
                {
                    nesne.BackColor = Color.SteelBlue;
                    nesne.Text = "deneme"; 
                }
                else
                {
                    nesne.BackColor = Color.Aquamarine;
                    sayi = sayi + 1;
                    nesne.Text = "Buton" + sayi;
                }
            }
            */
            /*
            Control nesne = this.Controls[0];
            Button btn = nesne as Button;
            if (btn==null)
            {
                this.Controls[0].BackColor = Color.Aquamarine;
                this.Controls[0].Text = "Buton";
            }
            else
            {
                this.Controls[0].BackColor = Color.SteelBlue;
                this.Controls[0].Text = "TextBox";
            }
            */
            /*
            if (this.Controls[0] is Button)
            {
                Control btn = this.Controls[0];
                btn.BackColor = Color.Aquamarine;
                btn.Text = "Buton";
            }
            else if (this.Controls[0] is TextBox)
            {
                Control txt = this.Controls[0];
                txt.BackColor = Color.SteelBlue;
                txt.Text = "TextBox";
            }
            */
            if (this.Controls[0] is Button btn)
            {
                btn.BackColor = Color.Aquamarine;
                btn.Text = "Buton";
            }
            else if (this.Controls[0] is TextBox txt)
            {
                txt.BackColor = Color.SteelBlue;
                txt.Text = "TextBox";
            }
        }
    }
}
