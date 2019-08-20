using System.Linq;

namespace CodeWars
{
    public class ExpressionsMatter
    {
        public static int LargestExpression(int a, int b, int c)
        {
            var numbers = new int[] {
        (a * (b +c)),
        ((a + b) * c),
        (a * b * c),
        (a + b + c)
        };

            return numbers.Max();
        }
    }
}
