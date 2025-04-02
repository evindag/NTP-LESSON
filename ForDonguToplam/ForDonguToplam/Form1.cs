using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDonguToplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int baslangic, bitis, toplam, carpim;
        private void button1_Click(object sender, EventArgs e)
        {
            
            toplam = 0;
            baslangic = Convert.ToInt32(textBox1.Text);
            bitis = Convert.ToInt32(textBox2.Text);
            

            for (int i = baslangic; i < bitis; i++)
            {
                toplam = toplam + i;
            }

            MessageBox.Show("sayıların toplamı : " + toplam.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carpim = 1;
            for (int i = baslangic; i < bitis; i++)
            {
                carpim = carpim * i;
            }

            MessageBox.Show("sayıların carpimi : " + carpim.ToString());
        }
    }
}
