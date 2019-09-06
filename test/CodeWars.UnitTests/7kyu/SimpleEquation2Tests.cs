using NUnit.Framework;
using System;
using CodeWars._7kyu;

namespace CodeWars.UnitTests._7kyu
{
    [TestFixture]
    class SimpleEquation2Tests
    {
        [Test]
        public void PlusTest()
        {
            Assert.AreEqual(957737, SimpleEquation2Kata.Result("854+584   + 956201   +98+0"), string.Format("Expect {0}, but it was {1}", 957737, SimpleEquation2Kata.Result("854+584   + 956201   +98+0")));
        }

        [Test]
        public void MinusTest()
        {
            Assert.AreEqual(-956029, SimpleEquation2Kata.Result("854-584   - 956201   -98-0"), string.Format("Expect {0}, but it was {1}", -956029, SimpleEquation2Kata.Result("854-584   - 956201   -98-0")));
        }

        [Test]
        public void PlusMinusTest()
        {
            Assert.AreEqual(-954665, SimpleEquation2Kata.Result("854+584   - 956201   +98-0"), string.Format("Expect {0}, but it was {1}", -954665, SimpleEquation2Kata.Result("854+584   - 956201   +98-0")));
        }
    }
}
