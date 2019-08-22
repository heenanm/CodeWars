using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    public class IsThisMyTailTests
    {
        [TestCase("Fox", "x", true)]
        [TestCase("Rhino", "o", true)]
        [TestCase("Meerkat", "t", true)]
        [TestCase("Emu", "t", false)]
        [TestCase("Badger", "s", false)]
        [TestCase("Giraffe", "d", false)]
        public void CorrectTail(string body, string tail, bool expected)
        {
            var actual = IsThisMyTailKata.CorrectTail(body, tail);

            Assert.AreEqual(expected, actual);
        }
    }
}