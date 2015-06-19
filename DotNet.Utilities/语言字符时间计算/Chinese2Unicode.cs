using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet_Utilities
{
   public class Chinese2Unicode
    {
       public static string ToChinese(string strUnicode)
       {
           string[] splitString = new string[1];
           splitString[0] = "\\u";
           string[] unicodeArray = strUnicode.Split(splitString, StringSplitOptions.RemoveEmptyEntries);
           StringBuilder sb = new StringBuilder();

           foreach (string item in unicodeArray)
           {
               byte[] codes = new byte[2];
               int code1, code2;
               code1 = Convert.ToInt32(item.Substring(0, 2), 16);
               code2 = Convert.ToInt32(item.Substring(2), 16);
               codes[0] = (byte)code2;//必须是小端在前
               codes[1] = (byte)code1;
               sb.Append(Encoding.Unicode.GetString(codes));
           }

           return sb.ToString();
       }
       public static string ToUnicode(string strChinese)
       {
           string strUnicodes = string.Empty;
           foreach (char item in strChinese.ToCharArray())
           {
               strUnicodes += "\\u" + ((int)item).ToString("x"); //16进制
           }
           return strUnicodes;
       }
    }
}
