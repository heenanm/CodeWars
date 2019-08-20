using NUnit.Framework;

namespace CodeWars.UnitTests
{
    public class DifferenceOfVolumesOfCuboidsTests
    {
        [TestCase(new int[] { 3, 2, 5 }, new int[] { 1, 4, 4 }, 14)]
        [TestCase(new int[] { 9, 7, 2 }, new int[] { 5, 2, 2 }, 106)]
        [TestCase(new int[] { 11, 2, 5 }, new int[] { 1, 10, 8 }, 30)]
        [TestCase(new int[] { 4, 4, 7 }, new int[] { 3, 9, 3 }, 31)]
        [TestCase(new int[] { 15, 20, 25 }, new int[] { 10, 30, 25 }, 0)]
        public void FindDifference(int[] a, int[] b, int expected)
        {
            var actual = DifferenceOfVolumesOfCuboidsKata.FindDifference(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
