using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    internal class YouOnlyNeedOneTests
    {
        [TestCase(new object[] {66, 101}, 66, true)]
        [TestCase(new object[] {80, 117, 115, 104, 45, 85, 112, 115}, 45, true)]
        [TestCase(new object[] {'t', 'e', 's', 't'}, 'e', true)]
        [TestCase(new object[] {"what", "a", "great", "kata"}, "kat", false)]
        public void Check(object[] a, object x, bool expected)
        {
            var actual = YouOnlyNeedOneKata.Check(a, x);

            Assert.AreEqual(expected, actual);
        }
    }
}