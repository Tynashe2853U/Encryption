using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace EncryptionApk
{

    public partial class Form1 : Form
    {
        private byte[] key;
        private byte[] iv;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

        }


        private void btnDecrypt_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            try
            {
                string plaintext = txtDecryptedText.Text; 
                // Generate a random key and IV
               // byte[] key, iv;
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    key = new byte[32]; // 256-bit key
                    iv = new byte[16]; // 128-bit IV

                    rng.GetBytes(key);
                    rng.GetBytes(iv);
                }
                // Encrypting the plaintext
                string encryptedBase64 = AESCryptoHelper.EncryptStringToBase64(plaintext, key, iv);
                txtEncryptedText.Text = encryptedBase64;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDecrypt_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the encrypted text from the TextBox
                string encryptedBase64 = txtEncryptedText.Text;

                // Ensure that key and iv are initialized
                if (key == null || iv == null)
                {
                    MessageBox.Show("Please encrypt a message first to generate the key and IV.");
                    return;
                }

                // Decrypt the text
                string decryptedText = AESDecryptor.DecryptBase64ToString(encryptedBase64, key, iv);

                // Display the decrypted text
                txtDecryptedText.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }

}