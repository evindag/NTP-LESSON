﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileContinue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 1;
            while (sayi<15)
            {
                sayi++;
                if (sayi==5 || sayi==10)
                {
                    continue;
                }
                listBox1.Items.Add(sayi);
            }
        }
    }
}
