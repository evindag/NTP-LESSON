using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa_127_uygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5]; 
        int[] notlar = new int[5];
        
        int index = 0;               
        

        private void button1_Click(object sender, EventArgs e)
        {
             if(index<isimler.Length)
 {
     isimler[index] = textBox1.Text;
     notlar[index] = int.Parse(textBox2.Text);
        index++;
        textBox1.Text = "";
        textBox2.Text = "";
 }
        }

        private void button5_Click(object sender, EventArgs e)
        {
             for (int i = 0; i < isimler.Length; i++)
                {
                    if(isimler[i] != null)
                {
                    listBox1.Items.Add(isimler[i]+" => "+notlar[i]);
 }
 }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int endusuk = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] < endusuk)
                    endusuk = notlar[i];
            }
            textBox4.Text = endusuk.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            textBox5.Text = ortalama.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] > enyuksek)
                    enyuksek = notlar[i];
            }
            textBox3.Text = enyuksek.ToString();
        }
    }
}
