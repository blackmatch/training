using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace training.tool
{
    class Tool
    {
        public static string getMd5Str(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] buffer = Encoding.Default.GetBytes(str);
            byte[] encryptedBuffer = md5.ComputeHash(buffer);
            string temStr = "";
            string paramStr = "x2";
           
            for (int i = 0; i < encryptedBuffer.Length; i++)
            {
                temStr += encryptedBuffer[i].ToString(paramStr);
            }

            return temStr;
        }
    }
}
