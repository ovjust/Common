using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace LTP.Common.DEncrypt
{
    public class MD5Encrypt
    {
        public MD5Encrypt()
        {

        }
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public static string MD5_Encrypt(string strSource)
        {
            return MD5_Encrypt(strSource, 16);
        }

        public static string MD5_Encrypt(string strSource, int length)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(strSource);
            byte[] hashValue = ((System.Security.Cryptography.HashAlgorithm)System.Security.Cryptography.CryptoConfig.CreateFromName("MD5")).ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            switch (length)
            {
                case 16:
                    for (int i = 4; i < 12; i++)
                        sb.Append(hashValue[i].ToString("x2"));
                    break;
                case 32:
                    for (int i = 0; i < 16; i++)
                    {
                        sb.Append(hashValue[i].ToString("x2"));
                    }
                    break;
                default:
                    for (int i = 0; i < hashValue.Length; i++)
                    {
                        sb.Append(hashValue[i].ToString("x2"));
                    }
                    break;
            }
            return sb.ToString();
        }

    }
}
