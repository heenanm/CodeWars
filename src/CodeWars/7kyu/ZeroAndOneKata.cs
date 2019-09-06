using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars._7kyu
{
    public class ZeroAndOneKata
    {
        public int ZeroAndOne(string s)
        {
            return Regex.Replace(s, "(10|01)", "").Length;
        }
    }
}
