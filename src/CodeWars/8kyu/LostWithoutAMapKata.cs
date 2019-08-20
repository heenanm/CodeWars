using System.Linq;

namespace CodeWars
{
    public class LostWithoutAMapKata
    {
        public static int[] Maps(int[] x)
        {
            var doubleX = x.Select(i => i * 2).ToArray();
            return doubleX;
        }
    }
}
