using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace UserManagement.LIBRARY.EncryptLib
{
    public static class HashStr
    {
        public static String SHA1Hash(String txt)
        {
            byte[] data = Encoding.UTF8.GetBytes(txt);
            using( SHA1 hash = SHA1.Create())
            {
                return BitConverter.ToString(hash.ComputeHash(data)).Replace("-",String.Empty).ToLower();
            }
        }
    }
}