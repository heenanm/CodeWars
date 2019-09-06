using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._7kyu
{
    public class MatchingPlatesKata
    {
        public static bool MatchingPlates(char[] meals, char[] stack)
        {
            return stack.ToString().Contains(meals.ToString()) && meals.Length <= stack.Length;
        }
    }
}
