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
        public byte[] byteKey;
        
        public string IV;
        public byte[] byteIV;
        
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
            ICryptoTransform xdecrypto = blobAes.CreateDecryptor(blobAes.Key, blobAes.IV);
            byteKey = blobAes.Key;
            byteIV = blobAes.IV;

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
            //blobAes.Dispose();
            byteKey = blobAes.Key;
            byteIV = blobAes.IV;
        }

        public void encrypt(string message, string alg)
        {
            clearText = message;            

            if (alg == "AES")
            {
                ICryptoTransform xdecrypto = blobAes.CreateDecryptor();
                byte[] byteClearText = Encoding.UTF8.GetBytes(clearText);
                byte[] byteCipher = cryptoXform.TransformFinalBlock(byteClearText, 0, byteClearText.Length);
                cipherByteAes = byteCipher;
                cipherTextAes = Convert.ToBase64String(byteCipher);
            }
        }
        public void decrypt(string alg)
        {
            if (alg == "AES")
            {

                decryptor = blobAes.CreateDecryptor(byteKey, byteIV);
                //byte[] byteCipherUnpadded = cipherByteAes;
                decryptedByteAes = decryptor.TransformFinalBlock(cipherByteAes, 0, cipherByteAes.Length ); // / blobAes.BlockSize
                decryptedText = Encoding.UTF8.GetString(decryptedByteAes);
                    //BitConverter.ToString(Decoding.UTF8(decryptedByteAes)).Replace("-","");
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