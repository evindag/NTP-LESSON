using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifiraBolunememeHatasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1, sayi2, sonuc;
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                sonuc = sayi1 / sayi2;
                MessageBox.Show("İşlem Başarılı. Sonuç : " +sonuc.ToString());
            }
            catch (System.DivideByZeroException ex)
            {
                MessageBox.Show("İşlem Başarısız ! Sayı sıfıra bölünemez " + ex.Message);
            }
        }
    }
}
