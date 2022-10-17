using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encryptor
{
    internal class AsymmetricEncryption
    {
        public RSA rsaBlob;
        public Aes aesBlob;

        public string publicKey;
        public byte[] publicKeyByte;

        public string privateKey;
        public byte[] privateKeyByte;

        public string clearText;
        public byte[] clearTextByte;

        public string cipherText;
        public byte[] cipherTextByte;

        public string initVec;
        public byte[] initVecByte;



        public AsymmetricEncryption()
        {
            RSA placeholderRsa = RSA.Create();
            rsaBlob = placeholderRsa;

            Aes placeholderAes = Aes.Create();
            aesBlob = placeholderAes;

        }
    }
}
