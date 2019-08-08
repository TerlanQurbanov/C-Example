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
namespace SortedList_IComparer
{
    public partial class Form1 : Form
    {
        public class Compare : IComparer
        {
            int IComparer.Compare(Object x, Object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SortedList sınıflar = new SortedList(new Compare());
            sınıflar.Add("E10A", "Endüstri Meslek");
            sınıflar.Add("E10B", "Endüstri Meslek");
            sınıflar.Add("T10A", "Teknik Lise");
            sınıflar.Add("A10A", "Anadolu Teknik");
            sınıflar.Add("A10B", "Anadolu Teknik");            
            foreach (DictionaryEntry eleman in sınıflar)
                listBox1.Items.Add(eleman.Key + " = " + eleman.Value);
        }
    }
}
