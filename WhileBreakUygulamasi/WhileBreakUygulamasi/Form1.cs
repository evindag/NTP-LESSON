using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileBreakUygulamasi
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
            while (sayi<=10)
            {
                sayi++;
                if (sayi==5)
                {
                    break; //break durdurmak anlamına gelir.
                }  
                listBox1.Items.Add(sayi);      
            }
        }
    }
}
