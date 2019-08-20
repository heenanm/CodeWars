using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class CenturyFromYearKata
    {
        public static double СenturyFromYear(int year)
        {
            return Math.Ceiling(year / 100d);
        }
    }
}
