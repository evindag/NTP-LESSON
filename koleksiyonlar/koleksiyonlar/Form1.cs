using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace koleksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();
        int sayac = 0;
        ArrayList ogrenciler = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {

            sehirler.Add(textBox1.Text);
            textBox1.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             ogrenciler.Add("Fatma");
             ogrenciler.Add("Ayşe");
             ogrenciler.Add("Merve");
             ogrenciler.Add("Ahmet");
             ogrenciler.Add("Kaan");
             foreach (string ad in ogrenciler)
                 listBox4.Items.Add(ad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string eleman in sehirler)
                listBox1.Items.Add(eleman);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sayac < listBox1.Items.Count)
            {
                listBox2.Items.Add(sehirler[sayac]);
                sayac++;
            }
            else
                MessageBox.Show("dizi sınırına ulaşıldı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox2.Text);
            sehirler[sayi] = textBox3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sehirler.Count; i++)
            {
                listBox3.Items.Add(sehirler[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            int sayi2 = int.Parse(textBox5.Text);
            ogrenciler.Insert(sayi2,textBox4.Text);
            foreach (string ad in ogrenciler)
                listBox4.Items.Add(ad);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ogrenciler.Remove("Ahmet");
            listBox4.Items.Clear();
            foreach (string ad in ogrenciler)
                listBox4.Items.Add(ad);
            
        

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ogrenciler.RemoveAt(3);
            listBox4.Items.Clear();
            foreach (string ad in ogrenciler)
                listBox4.Items.Add(ad);
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ogrenciler.Contains("Ahmet"))
            {
                label6.Text = "Aranan veri bulundu.";
                    
            }
            else
            {
                label6.Text = "Aranan veri bulunamadı.";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ogrenciler.Reverse();
            listBox4.Items.Clear();
            foreach (string ad in ogrenciler)
                listBox4.Items.Add(ad);
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ogrenciler.Sort();
            listBox4.Items.Clear();
            foreach (string ad in ogrenciler)
                listBox4.Items.Add(ad);
            
        }
    }
}
