using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encryptor
{
    public class SymmetricEncryption
    {
        public string clearText;
        public string hexKey;
        public string key;
        public string generatedKey;
        public string cipherText;
        public string IV;
        
        public SymmetricEncryption()
        {
        }

        private static byte[] HexToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }

        public void generate_key()
        {
            Aes blobAes = Aes.Create();
            blobAes.GenerateIV();
            blobAes.GenerateKey();
            generatedKey = BitConverter.ToString(blobAes.Key).Replace("-", " ");
            blobAes.Dispose();
        }

        private Aes CreateAesCipher()
        {
            Aes cipher = Aes.Create();
            cipher.Padding = PaddingMode.ISO10126;

            // cipher.Padding = Padding.Mode.Zeros;
            // cipher.Mode = CipherMode.ECB;

            //Create() makes a new key each time, use a consistent key for encryption/decryption
            cipher.Key = HexToByteArray(generatedKey);
            return cipher;
        }

        public void encrypt(string message, string alg)
        {
            clearText = message;            

            if (alg == "AES")
            {
                Aes aesCipher = CreateAesCipher();
                IV = Convert.ToBase64String(aesCipher.IV);
                ICryptoTransform cryptoTransform = aesCipher.CreateEncryptor();
                byte[] byteClearText = Encoding.UTF8.GetBytes(clearText);
                byte[] byteCipher = cryptoTransform.TransformFinalBlock(byteClearText, 0, byteClearText.Length);
                cipherText = Convert.ToBase64String(byteCipher);
            }
        }
        public void decrypt(string encryptedCipher, string encKey, string alg)
        {
            
        }
    }
}
