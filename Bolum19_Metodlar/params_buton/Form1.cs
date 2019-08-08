using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace params_buton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void pasif(bool onay, params Button[] btn)
        {
            byte i = 0;
            if (onay == true)            
                for (i = 0; i <= btn.Length - 1; i++)                
                    btn[i].Enabled = false;                
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pasif(true, btnGuncelle, btniptal, btnKaydet, btnSil);
        }
    }
}
