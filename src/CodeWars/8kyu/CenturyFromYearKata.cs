using System;

namespace CodeWars._8kyu
{
    public class CenturyFromYearKata
    {
        public static double СenturyFromYear(int year)
        {
            return Math.Ceiling(year / 100d);
        }
    }
}