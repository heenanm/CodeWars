using System.Linq;

namespace CodeWars
{
    public class StringRepeat
    {
        public static string RepeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }
    }
}
