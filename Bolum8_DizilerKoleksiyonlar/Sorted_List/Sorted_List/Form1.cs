using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorted_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int i;
            SortedList sınıflar = new SortedList();            
            sınıflar.Add("E10A", "Endüstri Meslek");
            sınıflar.Add("E10B", "Endüstri Meslek");
            sınıflar.Add("T10A", "Teknik Lise");
            sınıflar.Add("A10A", "Anadolu Teknik");
            sınıflar.Add("A10B", "Anadolu Teknik");

            //sınıflar["E10A"] = "Teknik Lise";
                        
            //foreach (DictionaryEntry eleman in sınıflar)
                //listBox1.Items.Add(eleman.Key + " = " + eleman.Value);          
            for (i=0; i < sınıflar.Count; i++) 
                listBox1.Items.Add(sınıflar.GetByIndex(i));
        }
    }
}
