using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_Haftanin_Gunleri_2
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
                case 2:        
                case 3:  
                case 4:    
                case 5:
                    MessageBox.Show("Haftaiçi");
                    break;
                case 6:   
                case 7:
                    MessageBox.Show("Haftasonu");
                    break;
                default:
                    MessageBox.Show("Bir Hata Oluştu.");
                    break;
            }
        }
    }
}
