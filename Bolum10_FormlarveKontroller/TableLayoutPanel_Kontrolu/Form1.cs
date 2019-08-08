using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableLayoutPanel_Kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.Location = new System.Drawing.Point(10,10);
            tlp.Name = "TableLayoutPanel1";
            tlp.Size = new System.Drawing.Size(200, 100);
            tlp.BackColor = Color.DarkGray;
            tlp.ColumnCount = 2;
            tlp.RowCount = 2;

            //tlp.ColumnStyles.Add(new RowStyle(SizeType.AutoSize));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            Label label1 = new Label();           
            label1.Text = "Kullanıcı Adı:";
            Label label2 = new Label();
            label2.Text = "Şifre:";  
            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();           

            tlp.Controls.Add(label1, 0, 0);
            tlp.Controls.Add(textBox1, 1, 0);
            tlp.Controls.Add(label2, 0, 1);
            tlp.Controls.Add(textBox2, 1, 1);
            this.Controls.Add(tlp); 
        }        
    }
}
