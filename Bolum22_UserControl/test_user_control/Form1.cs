using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_user_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            label1.Text = "Harf Sayısı= " + txt_metin.uzunluk.ToString();
            label2.Text = "Cümle Sayısı= " +
                txt_metin.cumle_sayısı.ToString();
        }
    }
}
