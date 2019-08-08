using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox_Secim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte i;
        private void btnTumunuSec_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= checkedListBox1.Items.Count - 1; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            label1.Text = checkedListBox1.CheckedItems.Count + " eleman seçili";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (i = 1; i <= 10; i++)
                checkedListBox1.Items.Add(i);
        }
        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= checkedListBox1.CheckedItems.Count - 1; i++)
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);           
        }
        private void btnSecimiKaldir_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= checkedListBox1.Items.Count - 1; i++)
                checkedListBox1.SetItemChecked(i, false);
            label1.Text = checkedListBox1.CheckedItems.Count +
                " eleman seçili";
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int sayi = checkedListBox1.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked) { ++sayi; }
            if (e.NewValue == CheckState.Unchecked) { --sayi; }                                      
            label1.Text = sayi.ToString()+" eleman seçili"; ;            
        }
    }
}
