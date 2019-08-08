using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace enum_erisim
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
        private void button1_Click(object sender, EventArgs e)
        {
            byte i = Convert.ToByte(Interaction.InputBox
                ("Gün numarasını giriniz"));
            Gunler gunadi;
            gunadi = (Gunler)i;
            MessageBox.Show(gunadi.ToString());

        }
    }
}
