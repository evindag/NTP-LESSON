using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case_gecti_kaldi_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "0":
                case "1":
                    label3.Text = "Kaldı";
                    break;
                case "2":
                case "3":
                case "4":
                case "5":
                    label3.Text = "geçti";
                    break;
                default:
                    MessageBox.Show("Lütfen 0-5 arasında bir sayı giriniz!");
                    break;
            }
        }
    }
}
