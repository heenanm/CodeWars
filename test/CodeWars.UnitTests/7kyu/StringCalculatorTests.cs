using NUnit.Framework;
using CodeWars._7kyu;

namespace CodeWars.UnitTests._7kyu
{
    [TestFixture]
    class StringCalculatorTests
    {
        [Test]
        public static void LessThan10()
        {
            Assert.AreEqual(5, StringCalculatorKata.AddStrings("2, 3"));
        }

        [Test]
        public static void LessThan20()
        {
            Assert.AreEqual(20, StringCalculatorKata.AddStrings("1, 2, 4, 13"));
        }

        [Test]
        public static void Over100()
        {
            Assert.AreEqual(431, StringCalculatorKata.AddStrings("111, 20, 300"));
        }

        [Test]
        public static void LargeNumber()
        {
            Assert.AreEqual(123927, StringCalculatorKata.AddStrings("111, 20, 20, 20, 300, 123456"));
        }

        [Test]
        public static void NegativeNumbers()
        {
            Assert.AreEqual(-2251, StringCalculatorKata.AddStrings("-47, 7, -55, -2156"));
        }

        [Test]
        public static void NumbersWithZero()
        {
            Assert.AreEqual(2380, StringCalculatorKata.AddStrings("0, 51, 2256, 0, 13, 60"));
        }

        [Test]
        public static void NumbersWithZeroAndNegatives()
        {
            Assert.AreEqual(-196, StringCalculatorKata.AddStrings("-123, 0, 0, -13, -60"));
        }
    }
}
