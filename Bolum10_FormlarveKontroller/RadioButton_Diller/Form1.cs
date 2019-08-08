using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_Diller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
                if (radioButton1.Checked )     
                     MessageBox.Show("En çok kullandığınız dil C#");    
                else if (radioButton2.Checked)  
                    MessageBox.Show("En çok kullandığınız dil Vb.Net");    
                else if (radioButton3.Checked)  
                    MessageBox.Show("En çok kullandığınız dil C");    
                else if (radioButton4.Checked)  
                    MessageBox.Show("En çok kullandığınız dil C++");    
                else if (radioButton5.Checked)  
                    MessageBox.Show("En çok kullandığınız dil Python");    
                else if (radioButton6.Checked)  
                    MessageBox.Show("En çok kullandığınız dil Ruby");    
                else if (radioButton7.Checked)  
                    MessageBox.Show("En çok kullandığınız dil Delphi");
        }
    }
}
