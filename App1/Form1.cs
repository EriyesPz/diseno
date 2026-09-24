namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = "Hola mundo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            n1 = Convert.ToInt32(this.textBox1.Text);
            n2 = Convert.ToInt32(this.textBox2.Text);
            n3 = n1 + n2;
            this.textBox3.Text = n3.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
