using System.Security.Cryptography;
using System.Text;

namespace LearnElectronics.CommonData
{
    public class Hashing
    {
        public static string HashValue(string value)
        {
            MD5 md5 = MD5.Create();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(value);
            byte[] hashPasswordArray = md5.ComputeHash(passwordBytes);
            md5.Dispose();
            string hashedPassword = string.Empty;
            for (int i = 0; i < hashPasswordArray.Length; i++)
            {
                hashedPassword += hashPasswordArray[i].ToString();
            }
            return hashedPassword;
        }
    }
}
