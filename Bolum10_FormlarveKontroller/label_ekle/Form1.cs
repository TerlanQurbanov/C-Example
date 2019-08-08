using System;
using System.Drawing;
using System.Windows.Forms;
namespace label_ekle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label Label1 = new Label();
            this.Controls.Add(Label1);
            Label1.Text = "Güzel gören güzel düşünür. \r\n Güzel düşünen hayatından lezzet alır.";
            Label1.Font = new Font("Comic Sans MS", 15, FontStyle.Italic);
            Label1.ForeColor = Color.DarkBlue;
            Label1.AutoSize = true;
        }
    }
}
