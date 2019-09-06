using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._7kyu
{
    public class StringCalculatorKata
    {
        public static int AddStrings(string numbers)
        {
            return numbers.Split(',').Sum(x => int.Parse(x));
        }
    }
}
