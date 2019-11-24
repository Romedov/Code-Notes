using System;
using System.Security.Cryptography;
using System.Text;

namespace CSharpLearn
{
    public static class SHA256ManagedHasher
    {
        public static string GetHash(string str, Encoding encode)
        {
            byte[] data = encode.GetBytes(str);
            var result = new SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }
        public static bool HashEquals(string inputStr, string encryptedStr, Encoding encode)
        {
            byte[] data = encode.GetBytes(inputStr);
            var result = new SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToLower() == encryptedStr;
        }
    }
}
