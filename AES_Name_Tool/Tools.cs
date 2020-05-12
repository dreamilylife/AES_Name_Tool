using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace AES_Name_Tool
{
    public class AES_Tools
    {
        public string do_check_and_revise_key(string key)
        {
            if (key.Length < 16)
                key = key + string.Concat(Enumerable.Repeat('0', (16 - key.Length)));
            else if (key.Length > 16)
                key = key.Substring(0, 16);
            return key;
        }

        public string do_encrypt_text(string text, string key)
        {
            byte[] plain_text = Encoding.UTF8.GetBytes(text);
            string encrypted_text = "";

            try
            {
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                byte[] crypto_key = Encoding.UTF8.GetBytes(key);
                aes.Mode = CipherMode.CBC;
                aes.KeySize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = crypto_key;
                aes.IV = crypto_key;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(plain_text, 0, plain_text.Length);
                        cs.FlushFinalBlock();
                        encrypted_text = Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return encrypted_text;
        }

        public string do_decrypt_text(string text, string key)
        {
            byte[] encrypted_text = Convert.FromBase64String(text);
            string decrypted_text = "";
            try
            {
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
                byte[] crypto_key = Encoding.UTF8.GetBytes(key);
                aes.Mode = CipherMode.CBC;
                aes.KeySize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = crypto_key;
                aes.IV = crypto_key;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encrypted_text, 0, encrypted_text.Length);
                        cs.FlushFinalBlock();
                        decrypted_text = Encoding.UTF8.GetString(ms.ToArray());
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return decrypted_text;
        }
    }
}
