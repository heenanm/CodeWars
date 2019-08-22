using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    internal class CountByXTests
    {
        [TestCase(1, 5, new[] {1, 2, 3, 4, 5})]
        [TestCase(2, 5, new[] {2, 4, 6, 8, 10})]
        public void CountBy(int x, int n, int[] expected)
        {
            var actual = CountByXKata.CountBy(x, n);

            Assert.AreEqual(expected, actual);
        }
    }
}