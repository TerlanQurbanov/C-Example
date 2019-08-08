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

namespace Hashtable_varsayilan_anahtar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Hashtable isimler = new Hashtable();
            isimler[0] = ("Volkan AKTAŞ");
            isimler[1] = ("İrfan MERGAN");
            isimler[2] = ("Bünyamin KARAHAN");
            isimler[3] = ("Hale KATMER");
            isimler[4] = ("Tamer MATBAN");

            foreach (DictionaryEntry eleman in isimler)
                listBox1.Items.Add(eleman.Key + " = " + eleman.Value);
        }
    }
}
