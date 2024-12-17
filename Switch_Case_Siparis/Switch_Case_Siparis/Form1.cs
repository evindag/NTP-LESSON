using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_Siparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenYemek = textBox1.Text;
            string secilenIcerik;
            int yemekUcret;
            switch (secilenYemek)
            {
                case "hamburger":
                    secilenIcerik="Patates,kola,ketçap ve mayonezle servis edilir.";
                    yemekUcret = 500;
                    break;
                case "pizza":
                    secilenIcerik="Patates,kola,ketçap ve mayonezle servis edilir.";
                    yemekUcret = 400;
                    break;
                default:
                    secilenIcerik = "Menümüzde böyle bir yemek bulunmamaktadır.";
                    yemekUcret= 0;
                    break;        
            }
            MessageBox.Show("Seçilen yemek: " + secilenYemek + "\nİçerik : " + secilenIcerik + "\nYemek Ücreti: " + yemekUcret.ToString());
        }
    }
}
