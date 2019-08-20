using NUnit.Framework;

namespace CodeWars.UnitTests
{
    class ExpressionsMatterTests
    {
        [TestCase(2, 1, 2, 6)]
        [TestCase(1, 1, 1, 3)]
        [TestCase(2, 1, 1, 4)]
        [TestCase(1, 2, 3, 9)]
        [TestCase(1, 3, 1, 5)]
        [TestCase(2, 2, 2, 8)]
        public void LargestExpression(int a, int b, int c, int expected)
        {
            var actual = ExpressionsMatter.LargestExpression(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
