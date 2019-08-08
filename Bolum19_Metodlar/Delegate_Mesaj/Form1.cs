using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Mesaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void DelegateMetod(string mesaj, string baslık)
        {
            MessageBox.Show(baslık, mesaj);
        }
        public delegate void Del_Metod(string mesaj, string baslık);
        private void btnMesaj_Click(object sender, EventArgs e)
        {
            Del_Metod event_handler = DelegateMetod;
            event_handler("Mesaj", "Delegate Örneği");
        }
    }
}
