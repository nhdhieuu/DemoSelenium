using System.Security.Cryptography;
using System.Text;
using DevOne.Security.Cryptography.BCrypt;

namespace SeleniumWPF
{
    public class Hashing
    {
        public static byte[] CalculateSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] hashValue;
            UTF8Encoding objUtf8 = new UTF8Encoding();
            hashValue = sha256.ComputeHash(objUtf8.GetBytes(str));

            return hashValue;
        }
        public static string HashToHexString(byte[] hash)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("X2")); 
            }
            return sb.ToString();
        }
        
        
    }
}