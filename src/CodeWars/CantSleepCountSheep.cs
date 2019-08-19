using System.Text;

namespace CodeWars
{
    public class CantSleepCountSheep
    {
        public static string CountSheep(int n)
        {
            var sheepCount = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                sheepCount.Append(i.ToString() + " sheep...");
            }

            return sheepCount.ToString();
        }
    }
}


