using NUnit.Framework;

namespace CodeWars.UnitTests
{
    class SumArraysTests
    {
        [TestCase(new double[] { 1, 5.2, 4, 0, -1 }, 9.2)]
        [TestCase(new double[] { }, 0)]
        public void SumArray(double[] array, double expected)
        {
            var actual = SumArraysKata.SumArray(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
