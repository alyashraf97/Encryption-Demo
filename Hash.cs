using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Encryptor
{
    public class Hash
    {
        public string clearText;
        //public enum algs {MD5, SHA1, SHA256, SHA512};
        public string cypherText;
        
        public Hash() // Hash class constructor
        {

        }


        public void compute_hash(string message, string alg)
        {
            clearText = message;
            byte[] hashed;
                
                if ( alg =="MD5") // MD5 hash
                {
                    MD5 md5Hash = MD5.Create();
                    byte[] hashedData = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(message));
                    cypherText = BitConverter.ToString(hashedData).Replace("-","");
                }

                else if (alg == "SHA1") // SHA-1 hash
                {
                    SHA1 sha1Hash = SHA1.Create();
                    byte[] hashedData = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(message));
                    cypherText = BitConverter.ToString(hashedData).Replace("-", "");
                }

                else if (alg == "SHA256") // SHA-256 Hash
                {
                    SHA256 sha256Hash = SHA256.Create();
                    byte[] hashedData = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(message));
                    cypherText = BitConverter.ToString(hashedData).Replace("-","");
                }

                else          // Should only leave SHA-512 hash //if (alg == "SHA512")      
                {
                    SHA512 sha512Hash = SHA512.Create();
                    byte[] hashedData = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(message));
                    cypherText = BitConverter.ToString(hashedData).Replace("-","");
                }            
            //}
        }

        public void clear()
        {
            clearText = "";
            cypherText= "";
        }
                


    }
}
