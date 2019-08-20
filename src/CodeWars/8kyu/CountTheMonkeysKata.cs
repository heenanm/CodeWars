using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class CountTheMonkeysKata
    {
        public static int[] MonkeyCount(int n)
        {
            var countArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                countArray[i] = i + 1;
            }
            return countArray;
        }
    }
}
