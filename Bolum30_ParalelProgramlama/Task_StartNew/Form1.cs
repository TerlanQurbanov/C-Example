﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
namespace Task_StartNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Task task1 = Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 30; i++)
                {
                    Thread.Sleep(500);
                    label1.Text = i + " ";
                }
            });
            Task task2 = Task.Factory.StartNew(() =>
            {
                for (int j = 1; j <= 30; j++)
                {
                    Thread.Sleep(500);
                    label2.Text = j + " ";
                }
            });
        }
    }
}
