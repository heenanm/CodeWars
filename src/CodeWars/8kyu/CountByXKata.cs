using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class CountByXKata
    {
        public static int[] CountBy(int x, int n)
        {
            var countArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                countArray[i] = (i + 1) * x;
            }
            return countArray;
        }
    }
}
