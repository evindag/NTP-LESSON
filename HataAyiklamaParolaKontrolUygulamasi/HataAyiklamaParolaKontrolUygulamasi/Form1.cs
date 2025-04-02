using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataAyiklamaParolaKontrolUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parola = textBox1.Text;
            string hataKodu;

            // Şifre Doğrulama İşlemi
            if (string.IsNullOrEmpty(parola))
            {
                hataKodu = "101";
                MessageBox.Show("Şifre Boş Bırakılamaz. Hata : " , hataKodu ,MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else if (parola.Length<8)
            {
                hataKodu = "102";
                MessageBox.Show("Şifre en az 8 karakterli olmalıdır. Hata : ", hataKodu, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!parolaOzelKarakterIceriyorMu(parola))
            {
                hataKodu = "103";
                MessageBox.Show("Şifre en az bir özel karakter içermelidir (#,@,! gibi) . Hata : ", hataKodu, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("GİRİŞ BAŞARILI ! ","BAŞARILI",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox1.Clear();
        }
        // Parolanın özel karakter içerip içermediğinin kontrolünü yapan blok
        private bool parolaOzelKarakterIceriyorMu(string parola)
        {
            string ozelKarakterleri = "!@#^%&$*()_+-";
            foreach (char karakter in parola)
            {
                if (ozelKarakterleri.Contains(karakter))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
