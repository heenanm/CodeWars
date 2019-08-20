using NUnit.Framework;

namespace CodeWars.UnitTests
{
    public class StringyStringsTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "10")]
        [TestCase(10, "1010101010")]
        public void Stringy(int size, string expected)
        {
            var actual = StringyStringsKata.Stringy(size);

            Assert.AreEqual(expected, actual);
        }
    }
}