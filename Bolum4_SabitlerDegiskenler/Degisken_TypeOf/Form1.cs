using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degisken_TypeOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ondalık_sayı = 12.4;
            if (ondalık_sayı.GetType() == typeof(byte))
            {
                MessageBox.Show("Değişken türü byte");
            }
            else
            {
                MessageBox.Show("Değişken türü byte değil");
            } 
        }
    }
}
