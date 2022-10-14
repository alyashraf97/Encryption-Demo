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

        //all the instance variables are in both string and byte format
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
        
        // Note to self: Maybe the byte arrays dont need to be public?!

        private ICryptoTransform encryptorBlock;
        private ICryptoTransform decryptorBlock;
        

        // Class Constructor
        public SymmetricEncryption()
        {
            Aes aesCipher = Aes.Create();   
            // Instantiate Aes class into aesCipher Object
            
            blobAes = aesCipher;    
            // saving the aesCipher object into the instance variable blobAes (Will need to refer to it)
            
            aesCipher.Dispose();    
            // goes out of scope


            // ********** Optional settings **********
            // cipher.Padding = Padding.Mode.Zeros;
            // cipher.Mode = CipherMode.ECB;
            //Create() makes a new key each time, use a consistent key for encryption/decryption


            IV = Convert.ToBase64String(blobAes.IV);
            // Converts the initialization vector from a byte array to a string (useful)

            blobAes.Padding = PaddingMode.ISO10126;
            // Padding option

            ICryptoTransform cryptoTransform = blobAes.CreateEncryptor();
            // Creates the initial Block Encryptor

            ICryptoTransform decryptorTransform = blobAes.CreateDecryptor(blobAes.Key, blobAes.IV);
            // Creates the initial Block Decryptor

            byteKey = blobAes.Key;
            byteIV = blobAes.IV;
            // Saves a byte array version of the Key and the initialization vector

            encryptorBlock = cryptoTransform;
            // Saves the block Encryptor Locally
            decryptorBlock = decryptorTransform;
            // Saves the block Decryptor locally

            //both go out of scope
            cryptoTransform.Dispose();
            decryptorTransform.Dispose();

        }

        
        // Method to Generate a new key and Initialization Vector
        public void GenerateKey()
        {
            // Generate a new IV
            blobAes.GenerateIV();
            IV = Convert.ToBase64String(blobAes.IV);
            byteIV = blobAes.IV;

            // Generate a new Key
            blobAes.GenerateKey();
            key = BitConverter.ToString(blobAes.Key).Replace("-", " ");
            byteKey = blobAes.Key;

            // Generate a new Block Encryptor
            encryptorBlock = blobAes.CreateEncryptor();
        }

        public void AesEncrypt(string message, string alg)
        {
            clearText = message;            

            if (alg == "AES")
            {
                // Turn cleartext into byte array
                byte[] byteClearText = Encoding.UTF8.GetBytes(clearText);

                // Encrypt the bloody thing
                byte[] byteCipher = encryptorBlock.TransformFinalBlock(byteClearText, 0, byteClearText.Length);
                
                // Attribute shenanigans
                cipherByteAes = byteCipher;
                cipherTextAes = Convert.ToBase64String(byteCipher);
            }
        }
        public void AesDecrypt(string alg)
        {
            if (alg == "AES")
            {
                // Generate the relevant decryption block
                decryptorBlock = blobAes.CreateDecryptor(byteKey, byteIV);
                decryptedByteAes = decryptorBlock.TransformFinalBlock(cipherByteAes, 0, cipherByteAes.Length ); 
                
                // Finally recover the original message
                decryptedText = Encoding.UTF8.GetString(decryptedByteAes);

                // WARNING: PROGRAM CRASHES WHEN THE CREATEDECRYPTOR METHOD GETS FED THE WRONG KEY
            }
        }
    }
}

