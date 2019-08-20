using NUnit.Framework;

namespace CodeWars.UnitTests
{
    public class CantSleepCountSheepTests
    {
        [TestCase(1, "1 sheep...")]
        [TestCase(2, "1 sheep...2 sheep...")]
        [TestCase(3, "1 sheep...2 sheep...3 sheep...")]
        public void CountSheep(int n, string expected)
        {
            var actual = CantSleepCountSheepKata.CountSheep(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
