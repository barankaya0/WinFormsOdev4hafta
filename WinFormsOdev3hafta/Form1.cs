namespace WinFormsOdev3hafta
{
    public partial class Form1 : Form
    {
        string adsoyad;
        string numara;
        string yazi;
        public Form1()
        {
            InitializeComponent();
        }

        List<string> adsoyadList = new List<string>();
        List<string> numaraList = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            adsoyad = textBox1.Text;
            numara = textBox2.Text;
            adsoyadList.Add(adsoyad);
            numaraList.Add(numara);
            MessageBox.Show("Ekleme baþarýlý!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < adsoyadList.Count; i++)
            {
                yazi = adsoyadList[i] + " " + numaraList[i];
                listBox1.Items.Add(yazi);
                comboBox1.Items.Add(yazi);
                MessageBox.Show("Aktarma Baþarýlý!");


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string secenek;
            secenek = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            string yazi2 = secenek + " Kullanýcýsýnýn þikayeti: \n" + richTextBox1.Text;
            listBox2.Items.Add(yazi2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            MessageBox.Show("Silindi!");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int ara = adsoyadList.Where(isim => isim.Contains(textBox3.Text)).Count();
            MessageBox.Show(textBox3.Text + " ismi listede " + ara + " adet bulunmaktadýr");
        }
    }
}