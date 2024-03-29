﻿using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
namespace TreeView_Sıralama
{   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSirala_Click(object sender, EventArgs e)
        {
            treeView1.TreeViewNodeSorter = new twSorter();
            //treeView1.Sort();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string[] klasorler = Directory.GetDirectories(textBox1.Text);
            treeView1.Nodes[0].Text = textBox1.Text;
            TreeNode anadugum = treeView1.Nodes[0];
            if (klasorler.Length != 0)
            {
                foreach (string aktifklasor in klasorler)
                {
                    TreeNode dugum = new TreeNode(aktifklasor);
                    anadugum.Nodes.Add(dugum);
                }
            }
            treeView1.ExpandAll();   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Klasör Listesi");
        }
    }
    public class twSorter : IComparer
    {        
        public int Compare(object x, object y)
        {
            TreeNode tx = x as TreeNode;
            TreeNode ty = y as TreeNode;
            return string.Compare(ty.Text, tx.Text);
        }
    }
}
