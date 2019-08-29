using System.Linq;

namespace CodeWars._8kyu
{
    public class LostWithoutAMapKata
    {
        public static int[] Maps(int[] x)
        {
            return x.Select(i => i * 2).ToArray();
        }
    }
}