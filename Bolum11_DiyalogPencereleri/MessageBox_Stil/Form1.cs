using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox_Stil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Mesaj", "Başlık", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);            
            //MessageBox.Show("Mesaj", "Başlık", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //MessageBox.Show("Birinci Satır \n" + "İkinci Satır", "Başlık", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //MessageBox.Show("Birinci Satır" + Environment.NewLine + "İkinci Satır","Başlık", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Soru",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            //MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Soru",MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0,MessageBoxOptions.RightAlign);
            //MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Soru",MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0,MessageBoxOptions.RtlReading);
            MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Soru",MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0, 0, true);


        }
    }
}
