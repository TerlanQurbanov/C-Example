using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helpProvider_SetHelpString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            helpProvider1.SetHelpString(txtAdSoyad,
                "Bu kontrol ile ilgili yardim mevcut");
        }
    }
}
