using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    internal class RepeatStringTests
    {
        [TestCase(3, "*", "***")]
        public void RepeatStr(int n, string s, string expected)
        {
            var actual = StringRepeatKata.RepeatStr(n, s);

            Assert.AreEqual(expected, actual);
        }
    }
}