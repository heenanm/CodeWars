using NUnit.Framework;

namespace CodeWars.UnitTests
{
    public class LostWithoutAMapTests
    {
        [TestCase(new[] { 1, 2, 3 }, new[] { 2, 4, 6 })]
        [TestCase(new[] { 4, 1, 1, 1, 4 }, new[] { 8, 2, 2, 2, 8 })]
        [TestCase(new[] { 2, 2, 2, 2, 2, 2 }, new[] { 4, 4, 4, 4, 4, 4 })]
        public void Maps(int[] x, int[] expected)
        {
            var actual = LostWithoutAMap.Maps(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
