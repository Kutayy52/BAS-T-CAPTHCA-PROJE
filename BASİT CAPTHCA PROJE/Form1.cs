namespace BASİT_CAPTHCA_PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] harf = { "a", "b", "c", "d", "e", "f", "g", "h", "k", "l" };
            string[] simge1 = { "!", "+", "-", "%", "/", "*", "?", "#", "=" };
            string[] sayı1 = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] simge2 = { "!", "+", "-", "%", "/", "*", "?", "#", "=" };
            string[] büyükharf = { "A", "B", "C", "D", "E", "F", "G", "H", "K", "L" };

            Random capht = new Random();
            int sm1=capht.Next(harf.Length);
            int sm2=capht.Next(simge1.Length);
            int sm3 = capht.Next(sayı1.Length);
            int sm4 = capht.Next(simge2.Length);
            int sm5 = capht.Next(büyükharf.Length);

            
            label1.Text = harf[sm1].ToString() + simge1[sm2].ToString() + sayı1[sm3].ToString() + simge2[sm4].ToString() + büyükharf[sm5].ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else textBox1.BackColor = Color.Red;

        }
    }
}