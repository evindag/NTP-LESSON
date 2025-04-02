using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = { 20000, 25000, 19000, 52000, 65000, 18000, 51000, 100000, 80000, 70000 };

        private void button1_Click(object sender, EventArgs e)
        {
            int uzunluk= sayilar.Length;
            MessageBox.Show("Dizinin uzunluğu :" + uzunluk.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int boyut = sayilar.Rank;
            MessageBox.Show("Dizinin boyutu :" + boyut.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int max = sayilar.Max();
            MessageBox.Show("Dizinin en büyük elemanı :" + max.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int min = sayilar.Min();
            MessageBox.Show("Dizinin en küçük elemanı :" + min.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int toplam = sayilar.Sum();
            MessageBox.Show("Dizinin elemanların toplam değeri:" + toplam.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
           double ortalama = sayilar.Average();
            MessageBox.Show("Dizinin elemanların ortalaması:" + ortalama.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int ilk = sayilar.First();
            MessageBox.Show("Dizinin ilk elemanı:" + ilk.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int son = sayilar.Last();
            MessageBox.Show("Dizinin son elemanı:" + son.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] != null)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
        }
    }

