using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    public class DifferenceOfVolumesOfCuboidsTests
    {
        [TestCase(new[] {3, 2, 5}, new[] {1, 4, 4}, 14)]
        [TestCase(new[] {9, 7, 2}, new[] {5, 2, 2}, 106)]
        [TestCase(new[] {11, 2, 5}, new[] {1, 10, 8}, 30)]
        [TestCase(new[] {4, 4, 7}, new[] {3, 9, 3}, 31)]
        [TestCase(new[] {15, 20, 25}, new[] {10, 30, 25}, 0)]
        public void FindDifference(int[] a, int[] b, int expected)
        {
            var actual = DifferenceOfVolumesOfCuboidsKata.FindDifference(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}