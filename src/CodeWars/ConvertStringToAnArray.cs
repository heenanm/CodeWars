using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class ConvertStringToAnArray
    {
        public static string[] StringToArray(string str)
        {
            string[] words = str.Split(' ');
            return words;
        }
    }
}
