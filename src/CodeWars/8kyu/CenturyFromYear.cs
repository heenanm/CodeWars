using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class CenturyFromYear
    {
        public static double СenturyFromYear(int year)
        {
            return Math.Ceiling(year / 100d);
        }
    }
}
