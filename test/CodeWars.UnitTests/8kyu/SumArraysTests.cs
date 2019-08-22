using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    internal class SumArraysTests
    {
        [TestCase(new[] {1, 5.2, 4, 0, -1}, 9.2)]
        [TestCase(new double[] { }, 0)]
        public void SumArray(double[] array, double expected)
        {
            var actual = SumArraysKata.SumArray(array);

            Assert.AreEqual(expected, actual);
        }
    }
}