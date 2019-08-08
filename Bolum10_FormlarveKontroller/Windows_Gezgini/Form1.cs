using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Gezgini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dirListBox1.Path = driveListBox1.Drive;
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path = dirListBox1.Path;
        }
        private void fileListBox1_DoubleClick(object sender, EventArgs e)
        {
            int n = fileListBox1.Path.IndexOf("\\");

            if (fileListBox1.Path == fileListBox1.Path.Substring(n, 1))
                System.Diagnostics.Process.Start
                      (fileListBox1.Path + fileListBox1.FileName);
            else
                System.Diagnostics.Process.Start
                        (fileListBox1.Path + "\\" + fileListBox1.FileName);        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDosyaTuru.SelectedIndex = 0;
            cmbNitelik.SelectedIndex = 0;
            fileListBox1.Pattern = cmbDosyaTuru.Text;
            fileListBox1.Archive = true;
        }
        private void cmbNitelik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNitelik.Text == "Arşiv Dosyaları")
                fileListBox1.Archive = true;
            if (cmbNitelik.Text == "Gizli Dosyalar")
                fileListBox1.Hidden = true;
            if (cmbNitelik.Text == "Sistem Dosyaları")
                fileListBox1.System = true;
            if (cmbNitelik.Text == "Yalnız Okunabilir Dosyalar")
                fileListBox1.ReadOnly = true;
            fileListBox1.Refresh();
        }
        private void cmbDosyaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Pattern = cmbDosyaTuru.Text;
        }
    }
}
