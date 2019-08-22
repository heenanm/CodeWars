using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    internal class CenturyFromYearTests
    {
        [TestCase(1705, 18)]
        [TestCase(1900, 19)]
        [TestCase(1601, 17)]
        [TestCase(2000, 20)]
        public void CenturyFromYear(int year, int expected)
        {
            var actual = CenturyFromYearKata.СenturyFromYear(year);

            Assert.AreEqual(expected, actual);
        }
    }
}