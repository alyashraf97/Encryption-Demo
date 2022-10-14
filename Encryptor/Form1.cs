namespace Encryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("MD5");
            comboBox1.Items.Add("SHA1");
            comboBox1.Items.Add("SHA256");
            comboBox1.Items.Add("SHA512");
        }
        Hash hashData = new Hash();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hashData.compute_hash(cleartextInput.Text,comboBox1.Text);
            hashOutput.Text = Convert.ToString(hashData.cypherText);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}