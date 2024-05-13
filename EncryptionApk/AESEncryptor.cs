using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class AESCryptoHelper
{
    private static byte[] EncryptStringToBytes(string plainText, byte[] key, byte[] iv)
    {
        // Check arguments
        if (string.IsNullOrEmpty(plainText))
            throw new ArgumentNullException(nameof(plainText));
        if (key == null || key.Length <= 0)
            throw new ArgumentNullException(nameof(key));
        if (iv == null || iv.Length <= 0)
            throw new ArgumentNullException(nameof(iv));

        byte[] encrypted;

        // Create an AES object with the specified key and IV
        using (AesManaged aesAlg = new AesManaged())
        {
            aesAlg.Key = key;
            aesAlg.IV = iv;

            // Create an encryptor to perform the stream transform
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            // Create the streams used for encryption
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        // Write all data to the stream
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
        }

        // Returning the encrypted bytes
        return encrypted;
    }

    public static string EncryptStringToBase64(string plainText, byte[] key, byte[] iv)
    {
        // Check arguments
        if (string.IsNullOrEmpty(plainText))
            throw new ArgumentNullException(nameof(plainText));
        if (key == null || key.Length <= 0)
            throw new ArgumentNullException(nameof(key));
        if (iv == null || iv.Length <= 0)
            throw new ArgumentNullException(nameof(iv));

        // Encrypt the plaintext
        byte[] encryptedBytes = EncryptStringToBytes(plainText, key, iv);

        // Convert the encrypted bytes to a base64-encoded string
        string encryptedBase64 = Convert.ToBase64String(encryptedBytes);

        return encryptedBase64;
    }
}