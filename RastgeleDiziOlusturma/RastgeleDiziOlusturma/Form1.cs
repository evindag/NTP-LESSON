using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleDiziOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] dizi;
        int satirSayisi;
        int sutunSayisi;

        private void btnDiziOlustur_Click(object sender, EventArgs e)
        {
            satirSayisi = Convert.ToInt16(txtSatirSayisi.Text);
            sutunSayisi = Convert.ToInt16(txtSutunSayisi.Text);
            int dusuk = Convert.ToInt16(txtDusuk.Text);
            int yuksek = Convert.ToInt16(txtYuksek.Text);
            

            dizi = new int[satirSayisi, sutunSayisi];
            Random rastgele = new Random();

            for (int x = 0; x < satirSayisi; x++)
            {
                for (int y = 0; y < sutunSayisi; y++)
                {
                    dizi[x, y] = rastgele.Next(dusuk, yuksek);
                }
            }
        }

        private void btnDiziGoster_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < satirSayisi; x++)
            {
                for (int y = 0; y < sutunSayisi; y++)
                {
                    listBox1.Items.Add(x + "," + y + "=>" + dizi[x, y]);
                }
            }
        }
    }
}
