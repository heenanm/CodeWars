using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class StringyStringsKata
    {
        public static string Stringy(int size)
        {
            var result = new StringBuilder();

            for (int i = 1; i <= size; i++)
            {
                if (i % 2 != 0)
                {
                    result.Append("1");
                }
                else
                {
                    result.Append("0");
                }
            }
            return result.ToString();
        }
    }
}
