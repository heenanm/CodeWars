using System.Linq;

namespace CodeWars
{
    public class StringRepeatKata
    {
        public static string RepeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }
    }
}
