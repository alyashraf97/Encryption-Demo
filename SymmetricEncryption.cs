using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using static System.Reflection.Metadata.BlobBuilder;

namespace Encryptor
{
    public class SymmetricEncryption
    {
        public Aes blobAes;

        public string clearText;
        public byte[] clearTextByte;

        public string cipherTextAes;
        public byte[] cipherByteAes;
        
        public string decryptedText;
        public byte[] decryptedByteAes;
        
        public string key;
        public string IV;
        
        private ICryptoTransform cryptoXform;
        private ICryptoTransform decryptor;
        
        public SymmetricEncryption()
        {
            Aes aesCipher = Aes.Create();
            blobAes = aesCipher;
            // cipher.Padding = Padding.Mode.Zeros;
            // cipher.Mode = CipherMode.ECB;
            //Create() makes a new key each time, use a consistent key for encryption/decryption

            IV = Convert.ToBase64String(blobAes.IV);
            blobAes.Padding = PaddingMode.ISO10126;

            ICryptoTransform cryptoTransform = blobAes.CreateEncryptor();
            ICryptoTransform xdecrypto = blobAes.CreateDecryptor();
            decryptor = xdecrypto;
            cryptoXform = cryptoTransform;
        }

        

        public void generate_key()
        {
            //Aes blobAes = Aes.Create();
            blobAes.GenerateIV();
            IV = Convert.ToBase64String(blobAes.IV);
            blobAes.GenerateKey();
            key = BitConverter.ToString(blobAes.Key).Replace("-", " ");
            cryptoXform = blobAes.CreateEncryptor();
            //blobAes.Key = blobAes.Key;
            blobAes.Dispose();
        }

        public void encrypt(string message, string alg)
        {
            clearText = message;            

            if (alg == "AES")
            {
                
                byte[] byteClearText = Encoding.UTF8.GetBytes(clearText);
                byte[] byteCipher = cryptoXform.TransformFinalBlock(byteClearText, 0, byteClearText.Length);
                cipherByteAes = byteCipher;
                cipherTextAes = Convert.ToBase64String(byteCipher);
            }
        }
        public void decrypt(byte[] encryptedCipher, string alg)
        {
            if (alg == "AES")
            {
                decryptedByteAes = decryptor.TransformFinalBlock(encryptedCipher, 0, cipherTextAes.Length);                
            }
        }
    }
}


/*private static byte[] HexToByteArray(string hex)
{
    return Enumerable.Range(0, hex.Length)
        .Where(x => x % 2 == 0)
        .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
        .ToArray();
}
private Aes CreateAesEncryptor()
{
    Aes blobAes = Aes.Create();




    blobAes.Key = generatedKey;
    return blobAes;
}

*/