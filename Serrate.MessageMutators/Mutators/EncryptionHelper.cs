using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Mutators
{
    public static class EncryptionHelper
    {
        private static byte[] key = Encoding.ASCII.GetBytes("TESTtestTESTtest");
        private static byte[] iv = Encoding.ASCII.GetBytes("Encryption.12345");

        public static byte[] Encrypt(byte[] textBytes)
        {
            byte[] encryptedBytes;

            using (var rijndael = new RijndaelManaged())
            {
                ICryptoTransform encryptor = rijndael.CreateEncryptor(key, iv);

                using (var memoryStream = new MemoryStream())
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(textBytes, 0, textBytes.Length);
                    cryptoStream.FlushFinalBlock();

                    encryptedBytes = memoryStream.ToArray();
                }                
            }

            return encryptedBytes;
        }

        public static byte[] Decrypt(byte[] textBytes)
        {
            string plainText;
            byte[] plainBytes;

            using (var rijndael = new RijndaelManaged())
            {
                ICryptoTransform decryptor = rijndael.CreateDecryptor(key, iv);

                using (var memoryStream = new MemoryStream(textBytes))
                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (var sr = new StreamReader(cryptoStream))
                    {
                        plainText = sr.ReadToEnd();
                    }
                    plainBytes = Encoding.ASCII.GetBytes(plainText);
                }
            }

            return plainBytes;
        }
    }
}
