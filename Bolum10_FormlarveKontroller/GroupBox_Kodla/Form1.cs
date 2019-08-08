using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox_Kodla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GroupBox groupBox1 = new GroupBox();
            Label label1 = new Label();
            label1.Location = new Point(20, 30);
            label1.Text = "Adı Soyadı: ";
            TextBox text1 = new TextBox();
            text1.Text = "Volkan AKTAŞ";
            text1.Location = new Point(150, 30);
            Controls.Add(groupBox1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.AutoSize = true;
            groupBox1.Left = groupBox1.Padding.Left +
                             groupBox1.Margin.Left;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(text1);
        }
    }
}
