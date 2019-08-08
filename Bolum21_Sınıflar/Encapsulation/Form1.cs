using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Encapsulation.snf_encaps nsn_encaps = new Encapsulation.snf_encaps();
            MessageBox.Show(nsn_encaps.x_property.ToString());
            nsn_encaps.A();
            //B ye erişim olamaz.
            //nsn_encaps.B() 
            nsn_encaps.mtd_B_ye_KendiSinifindanErisim();
            //PI 'ye erişilebiliniyor ama üzerinde değişiklik yapılamıyor.
            MessageBox.Show(nsn_encaps.PI.ToString());
            //nsn_encaps.PI = 5
        }
    }
}
