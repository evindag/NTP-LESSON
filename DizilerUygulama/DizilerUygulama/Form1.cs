using System;
using System.Threading;

namespace DizilerUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler = new string[5]; //Ad soyad için Global dizi 
        int[] notlar = new int[5]; //Notlar için Global dizi
        int index = 0; //Global deðiþken
        private void btnEnYuksek_Click(object sender, EventArgs e)
        {
            {
                int enyuksek = notlar[0];
                for (int i = 0; i < notlar.Length; i++)
                {
                    if (notlar[i] > enyuksek)
                    {
                        enyuksek = notlar[i];
                    }
                }
                txtEnYuksek.Text = enyuksek.ToString();
            }
        }

        private void btnEnDusuk_Click(object sender, EventArgs e)
        {
            {
                int endusuk = notlar[0];
                for (int i = 0; i < notlar.Length; i++)
                {
                    if (notlar[i] < endusuk)
                        endusuk = notlar[i];
                }
                txtEnDusuk.Text = endusuk.ToString();
            }
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            txtOrtalama.Text = ortalama.ToString();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                {
                    listBox1.Items.Add(isimler[i] + " > " + notlar[i]);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = txtAdSoyad.Text;
                notlar[index] = Convert.ToInt32(txtDersNotu.Text);
                // int.Parse fonksiyonu girilen deðeri “int” veri türüne dönüþtürür
                index++;
                txtAdSoyad.Text = "";
                txtDersNotu.Text = "";
            }
        }
    } }