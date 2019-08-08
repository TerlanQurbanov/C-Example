﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace try_catch_icinde_throw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte notu;
                notu = Convert.ToByte(Interaction.InputBox("Notu Girin",
                    "Not Girişi"));
                if (notu < 45)
                {
                    MessageBox.Show("Kaldınız");
                }
                else if (notu >= 45 & notu <= 100)
                {
                    MessageBox.Show("Geçtiniz");
                }
                else if (notu > 100)
                {
                    try
                    {
                        throw new OverflowException("100'den büyük bir değer girdiniz");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Öngörülen sınırlar dışında bir değer girdiniz");
            }
            catch (FormatException)
            {
                MessageBox.Show("Rakam girmelisiniz");
            }

        }
    }
}
