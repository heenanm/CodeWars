namespace CodeWars._8kyu
{
    public class CountTheMonkeysKata
    {
        public static int[] MonkeyCount(int n)
        {
            var countArray = new int[n];

            for (var i = 0; i < n; i++)
            {
                countArray[i] = i + 1;
            }

            return countArray;
        }
    }
}