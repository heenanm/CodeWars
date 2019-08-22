using System.Linq;

namespace CodeWars._8kyu
{
    public class ExpressionsMatterKata
    {
        public static int LargestExpression(int a, int b, int c)
        {
            var numbers = new[]
            {
                a * (b + c),
                (a + b) * c,
                a * b * c,
                a + b + c
            };

            return numbers.Max();
        }
    }
}