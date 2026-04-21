using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PosAndAccountant_business
{
    internal class clsCryptography
    {

        public static string GenerateSalt(int size = 16)
        {
            var salt = new byte[size];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            return Convert.ToBase64String(salt);
        }

        public static string Hashing(string data, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {

                byte[] Bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(data+ salt));
                return BitConverter.ToString(Bytes).Replace("-", "").ToLower();
            }

        }

            
    }
}
