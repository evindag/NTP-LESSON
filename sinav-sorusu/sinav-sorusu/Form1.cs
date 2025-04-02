namespace sinav_sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(textBox1.Text);
            int islem = (deger * 5 + 5 )/ 3;
            MessageBox.Show(islem.ToString());
            
            if(islem % 3 == 0) 
            {
                MessageBox.Show("Ýþleminiz hem 3 ' ün hem 5'in bir katýdýr.");
            }
            else
            {
                MessageBox.Show("Ýþleminiz hem 3 ' ün hem 5'in bir katý deðildir.");
            }
        }
    }
}
