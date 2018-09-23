using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConversionApp
{
    static class Operations
    {
        //private static string s;

        public static string reverse(string s)
        {
            char[] array = s.ToCharArray();
            char[] reversedStringChars = new char[array.Length];
            for(int i = array.Length - 1; i >= 0; i--)
            {
                reversedStringChars[i] = array[array.Length - i - 1];
            }

            string newString = new string(reversedStringChars);
            return newString;
        }

    }
}
