using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhileDongusuOrnek
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
            /*while (sayi<10)
            {
                listBox1.Items.Add(sayi);
                sayi++;
            }
            */
            do
            {
                listBox1.Items.Add(sayi);
                sayi++;
            } while (sayi<10);

        }
    }
}
