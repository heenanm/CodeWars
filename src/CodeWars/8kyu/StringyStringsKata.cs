using System.Text;

namespace CodeWars._8kyu
{
    public class StringyStringsKata
    {
        public static string Stringy(int size)
        {
            var result = new StringBuilder();

            for (var i = 1; i <= size; i++)
                if (i % 2 != 0)
                    result.Append("1");
                else
                    result.Append("0");
            return result.ToString();
        }
    }
}