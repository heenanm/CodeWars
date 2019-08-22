using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    internal class CountTheMonkeysTests
    {
        [TestCase(5, new[] {1, 2, 3, 4, 5})]
        [TestCase(3, new[] {1, 2, 3})]
        [TestCase(9, new[] {1, 2, 3, 4, 5, 6, 7, 8, 9})]
        [TestCase(10, new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10})]
        [TestCase(20, new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20})]
        public void MonkeyCount(int n, int[] expected)
        {
            var actual = CountTheMonkeysKata.MonkeyCount(n);

            Assert.AreEqual(expected, actual);
        }
    }
}