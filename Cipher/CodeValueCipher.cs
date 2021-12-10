using System;
using System.Text;

namespace Cipher
{
    public class CodeValueCipher : ICodeValueCipher
    {
        public string Encrypt(string message, string key)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                var letter = message[i];
                var isUpper = Char.IsUpper(letter);
                int index = char.ToUpper(letter) - 65;
                var result = key[index];
                if (!isUpper)
                {
                    result = char.ToLower(result);
                }
                sb.Append(result);
            }
            return sb.ToString();

        }

        public string Decrypt(string message, string key)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                var letter = message[i];

                var isUpper = Char.IsUpper(letter);
                int index = key.IndexOf(char.ToUpper(letter));

                var result = alphabet[index];
                if (!isUpper)
                {
                    result = char.ToLower(result);
                }
                sb.Append(result);
            }
            return sb.ToString();
        }
    }
}
