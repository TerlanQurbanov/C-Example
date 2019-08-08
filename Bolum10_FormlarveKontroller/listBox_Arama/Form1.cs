using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox_Arama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        Boolean bulundu = false;
        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 100; i++)
                listBox1.Items.Add(i);
        }

        private void Arama_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= listBox1.Items.Count - 1; i++)
            {
                if (txtAranan.Text == listBox1.Items[i].ToString())
                {
                    bulundu = true;
                    listBox1.SelectedIndex =
                        Int32.Parse(listBox1.Items[i].ToString());
                    break;
                }
                else bulundu = false;
            }
            if (bulundu == true)            
                MessageBox.Show("Bulundu");            
            else            
                MessageBox.Show("Bulunamadı");
        }
    }
}
