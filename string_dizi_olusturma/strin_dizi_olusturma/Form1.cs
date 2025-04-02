using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strin_dizi_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[5];
            dizi[0] = "Evin";
            dizi[1] = "Ahmet";
            dizi[2] = "Damla";
            dizi[3] = "İpek";
            dizi[4] = "Eyüp";

          foreach (string eleman in dizi)
	        {
                listBox1.Items.Add(eleman);
	        }
    }
    }
}
