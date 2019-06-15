using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet35FSol
{
    public static class StringFunctions
    {
        public static string Reverse(this string value) {
            char[] ch=value.ToCharArray();

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(ch[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
