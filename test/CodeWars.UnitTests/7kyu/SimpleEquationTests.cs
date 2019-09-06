using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System;
using CodeWars._7kyu;

namespace CodeWars.UnitTests._7kyu
{
    [TestFixture]
    class SimpleEquationTests
    {
        [Test]
        public void TestPlus()
        {
            StringAssert.AreEqualIgnoringCase("x = 17", SimpleEquationKata.SolveTheEquation("x + 85 = 102"),
                "Plus operator test failed");
        }

        [Test]
        public void TestMultiply()
        {
            StringAssert.AreEqualIgnoringCase("x = 68.15", SimpleEquationKata.SolveTheEquation("x * 1358 = 92548"),
                "Multiply operator test failed");
        }

        [Test]
        public void TestMinus()
        {
            StringAssert.AreEqualIgnoringCase("x = 6553", SimpleEquationKata.SolveTheEquation("x - 1003 = 5550"),
                "Minus operator test failed");
        }

        [Test]
        public void TestDivide()
        {
            StringAssert.AreEqualIgnoringCase("x = 63250", SimpleEquationKata.SolveTheEquation("x / 5 = 12650"),
                "Divide operator test failed");
        }
    }
}
