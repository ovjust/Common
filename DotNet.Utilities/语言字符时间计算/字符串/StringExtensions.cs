using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet_Utilities
{
    public static class StringExtensions
    {
       public static string ToTitleCase(this string s)
       {
           if(s.Length>0)
                s= char.ToUpper(s[0])+s.Substring(1);
           return s;
       }
    }
}
