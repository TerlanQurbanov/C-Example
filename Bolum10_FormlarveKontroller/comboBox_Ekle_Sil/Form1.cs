using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox_Ekle_Sil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            byte i;
            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    comboBox1.Items.Add(i);
            }
            label1.Text = comboBox1.Items.Count + " adet eleman var";
            comboBox1.SelectedIndex = 0;
        }

        private void btnYerlestir_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Insert(0, -1);
            comboBox1.SelectedIndex = 0;
            label1.Text = comboBox1.Items.Count + " adet eleman var";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            label1.Text = comboBox1.Items.Count + " adet eleman var";
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
            else
                comboBox1.Items.Remove(comboBox1.Items[0]);
            comboBox1.SelectedIndex = 0;
            label1.Text = comboBox1.Items.Count + " adet eleman var";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Seçili eleman= " +
            comboBox1.Items[comboBox1.SelectedIndex];
        }
    }
}
