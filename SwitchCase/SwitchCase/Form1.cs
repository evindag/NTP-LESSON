using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            private void button1_Click(object sender, EventArgs e)
            {
                string secilenYemek = textBox1.Text.ToLower(); // Kullanıcı girişini küçük harflere dönüştürüyoruz

                string yemekIcerik;
                double yemekFiyat;

                switch (secilenYemek)
                {
                    case "hamburger":
                        yemekIcerik = "Kıymalı köfte, marul, domates, turşu, ketçap ve mayonez ile servis edilir.";
                        yemekFiyat = 15.99;
                        break;
                    case "pizza":
                        yemekIcerik = "Mozzarella peyniri, domates sosu, jambon, mantar, yeşil biber ve zeytin ile hazırlanmıştır.";
                        yemekFiyat = 18.50;
                        break;
                    case "salata":
                        yemekIcerik = "Karışık yeşillikler, rendelenmiş havuç, domates, salatalık ve dilimlenmiş biber ile sunulur.";
                        yemekFiyat = 12.75;
                        break;
                    default:
                        yemekIcerik = "Menümüzde bu yemek bulunmamaktadır.";
                        yemekFiyat = 0.00;
                        break;
                }

                MessageBox.Show("Seçilen Yemek: " + secilenYemek.ToUpper() + "\nİçerik: " + yemekIcerik + "\nFiyat: $" + yemekFiyat.ToString("0.00"));
            }
        }
    }
    

