using NUnit.Framework;

namespace CodeWars.UnitTests
{
    class CenturyFromYearTests
    {
        [TestCase(1705, 18)]
        [TestCase(1900, 19)]
        [TestCase(1601, 17)]
        [TestCase(2000, 20)]
        public void CenturyFromSpecificYear(int year, int expected)
        {
            var actual = CenturyFromYear.СenturyFromYear(year);

            Assert.AreEqual(expected, actual);
        }
    }
}
