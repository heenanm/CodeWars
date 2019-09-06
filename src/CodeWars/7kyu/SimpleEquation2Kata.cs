using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._7kyu
{
    public class SimpleEquation2Kata
    {
        public static int Result(string stringInput)
        {
            var convertString = stringInput.Replace(" ", "").Replace("+", " + ").Replace("-", " - ");
            var splitString = convertString.Split(' ');

            var total = int.Parse(splitString[0]);

            for (int i = 1; i < splitString.Length; i++)
            {
                if (splitString[i] == "+")
                {
                    total += int.Parse(splitString[i + 1]);
                    i += 1;
                }

                if (splitString[i] == "-")
                {
                    total -= int.Parse(splitString[i + 1]);
                    i += 1;
                }
            }

            return total;
        }
    }
}
