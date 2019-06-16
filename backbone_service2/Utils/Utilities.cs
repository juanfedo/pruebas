using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace backbone_service2.Utils
{
    public class Utilities
    {        

        public string Encrypt(string value)
        {
            UTF8Encoding UTF8 = new UTF8Encoding();
            AesManaged tdes = new AesManaged
            {
                Key = UTF8.GetBytes("MMMXXXKKK"),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform crypt = tdes.CreateEncryptor();
            byte[] plain = Encoding.UTF8.GetBytes(value);
            byte[] cipher = crypt.TransformFinalBlock(plain, 0, plain.Length);
            String encryptedText = Convert.ToBase64String(cipher);
            return encryptedText;
        }

        public String Decrypt(String value)
        {
            UTF8Encoding UTF8 = new UTF8Encoding();
            AesManaged tdes = new AesManaged
            {
                Key = UTF8.GetBytes("MMMXXXKKK"),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform crypt = tdes.CreateDecryptor();
            byte[] plain = Convert.FromBase64String(value);
            byte[] cipher = crypt.TransformFinalBlock(plain, 0, plain.Length);
            String encryptedText = Encoding.UTF8.GetString(cipher);
            return encryptedText;
        }

        public void write_log(string log_name, string text)
        {
            using (StreamWriter log = new StreamWriter(log_name, true))
                log.WriteLine(DateTime.Now.ToShortTimeString() + " ::: " + text);
        }

    }
}