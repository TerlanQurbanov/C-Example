using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace user_control
{    
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public int uzunluk
        {
            get 
            {                                  
                int harfsayisi=0,noktasayisi, bosluksayisi;
                noktasayisi = metin_kutusu.Text.Split('.').Length-1;
                bosluksayisi = metin_kutusu.Text.Split(' ').Length-1;
                harfsayisi = metin_kutusu.Text.Length
                    - (bosluksayisi + noktasayisi);
                return (harfsayisi);
            }
        }
        public int cumle_sayısı
        {
            get
            {
                int noktasayisi;
                noktasayisi = metin_kutusu.Text.Split('.').Length - 1;                
                return (noktasayisi);
            }
        }       
        public string yazan
        {
            get { return "Volkan AKTAŞ"; }
        }
    }
}
