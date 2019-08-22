namespace CodeWars._8kyu
{
    public class CountByXKata
    {
        public static int[] CountBy(int x, int n)
        {
            var countArray = new int[n];
            for (var i = 0; i < n; i++) countArray[i] = (i + 1) * x;
            return countArray;
        }
    }
}