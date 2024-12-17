using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_Haftanin_Gunleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int gun = Convert.ToInt16(textBox1.Text);

            switch (gun)
            {
                case 1:
                    MessageBox.Show("Pazartesi");
                    break;
                case 2:
                    MessageBox.Show("Salı");
                    break;
                case 3:
                    MessageBox.Show("Çarşamba");
                    break;
                case 4:
                    MessageBox.Show("Perşembe");
                    break;
                case 5:
                    MessageBox.Show("Cuma");
                    break;
                case 6:
                    MessageBox.Show("Cumartesi");
                    break;
                case 7:
                    MessageBox.Show("Pazar");
                    break;
                default:
                    MessageBox.Show("Bir Hata Oluştu.");
                    break;
            }
        }
    }
}
