namespace WinFormsApp1
{
    public partial class lbWelcome : Form
    {
        public lbWelcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname =textBox1.Text;
            txt1.Text="Hello "+fname;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}