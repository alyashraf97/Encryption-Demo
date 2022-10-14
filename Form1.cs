using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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
            comboBox1.SelectedIndex = 3;
            comboBox2.Items.Add("AES");
            comboBox2.SelectedIndex = 0;
        }
        Hash hashData = new Hash();
        SymmetricEncryption symEnc = new SymmetricEncryption();

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
            hashOutput.Text = hashData.cypherText;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hashData.clear();
            hashOutput.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            symEnc.decrypt(comboBox2.Text);
            symDecrypted.Text = symEnc.decryptedText;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void symEncryptBtn_Click(object sender, EventArgs e)
        {
            if (symMsg.Text != "" && symKey.Text != "")
            {                
                symEnc.encrypt(symMsg.Text, comboBox2.Text);
                symCipher.Text = symEnc.cipherTextAes;
                symIV.Text = symEnc.IV;
            }
            else
            {
                symCipher.Text = "Error, One of the fields is empty! [Either generate a key or enter a message]";
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void generateSymEncKey_Click(object sender, EventArgs e)
        {
            symEnc.generate_key();
            symKey.Text = symEnc.key.Replace("-", " ");
        }
    }
}