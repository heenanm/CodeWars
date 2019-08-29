using System.Text;

namespace CodeWars._8kyu
{
    public class CantSleepCountSheepKata
    {
        public static string CountSheep(int n)
        {
            var sheepCount = new StringBuilder();

            for (var i = 1; i <= n; i++)
            {
                sheepCount.Append(i + " sheep...");
            }

            return sheepCount.ToString();
        }
    }
}