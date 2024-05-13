using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class AESDecryptor
{
    private static string DecryptBytesToString(byte[] cipherText, byte[] key, byte[] iv)
    {
        // Check arguments
        if (cipherText == null || cipherText.Length <= 0)
            throw new ArgumentNullException(nameof(cipherText));
        if (key == null || key.Length <= 0)
            throw new ArgumentNullException(nameof(key));
        if (iv == null || iv.Length <= 0)
            throw new ArgumentNullException(nameof(iv));

        string plaintext = null;

        // Create an AES object with the specified key and IV
        using (AesManaged aesAlg = new AesManaged())
        {
            aesAlg.Key = key;
            aesAlg.IV = iv;

            // Create a decryptor to perform the stream transform
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            // Create the streams used for decryption
            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        // Read the decrypted bytes from the decrypting stream
                        plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
        }

        // Return the decrypted string
        return plaintext;
    }

    public static string DecryptBase64ToString(string cipherTextBase64, byte[] key, byte[] iv)
    {
        // Check arguments
        if (string.IsNullOrEmpty(cipherTextBase64))
            throw new ArgumentNullException(nameof(cipherTextBase64));
        if (key == null || key.Length <= 0)
            throw new ArgumentNullException(nameof(key));
        if (iv == null || iv.Length <= 0)
            throw new ArgumentNullException(nameof(iv));

        // Convert the base64-encoded string to encrypted bytes
        byte[] cipherText = Convert.FromBase64String(cipherTextBase64);

        // Decrypt the bytes to a plaintext string
        string plaintext = DecryptBytesToString(cipherText, key, iv);

        return plaintext;
    }
}