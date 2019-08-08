using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enum_isdefined
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum Gunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        }
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            if (Gunler.IsDefined(typeof(Gunler), "Pazartesi"))
            {
                MessageBox.Show("Pazartesi değeri mevcut");
            }
            else
            {
                MessageBox.Show("Pazartesi değeri mevcut değil");
            }

            //if (Gunler.IsDefined(typeof(Gunler), 0))
            //{
            //MessageBox.Show("Pazartesi değeri mevcut");
            //}
            //else
            //{
            //MessageBox.Show("Pazartesi değeri mevcut değil");
            //}
        }
    }
}
