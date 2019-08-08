using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helpProvider_Kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "\\yardim.chm";
            helpProvider1.SetHelpKeyword(txtAdSoyad, "Numara");
            helpProvider1.SetHelpNavigator(txtAdSoyad,
                HelpNavigator.AssociateIndex);
            helpProvider1.SetShowHelp(txtAdSoyad, true);         
        }
    }
}
