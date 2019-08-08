using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toolTip_Kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.ToolTipTitle = "Uyarı";
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(txtAdSoyad,
                        "Bu alana yalnızca string bilgi giriniz!");
            toolTip1.SetToolTip(txtNumara,
                        "Bu alana yalnızca rakam giriniz!");
        }
    }
}
