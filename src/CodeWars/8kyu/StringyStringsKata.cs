using System.Text;

namespace CodeWars._8kyu
{
    public class StringyStringsKata
    {
        public static string Stringy(int size)
        {
            var result = new StringBuilder();

            for (var i = 1; i <= size; i++)
            {
                result.Append(i % 2 != 0 ? "1" : "0");
            }

            return result.ToString();
        }
    }
}