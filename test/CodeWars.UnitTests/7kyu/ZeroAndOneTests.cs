using NUnit.Framework;
using System;
using CodeWars._7kyu;

namespace CodeWars.UnitTests._7kyu
{
    [TestFixture]
    class ZeroAndOneTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new ZeroAndOneKata();

            Assert.AreEqual(1, kata.ZeroAndOne("01010"));

            Assert.AreEqual(6, kata.ZeroAndOne("11101111"));

            Assert.AreEqual(0, kata.ZeroAndOne("01"));

            Assert.AreEqual(0, kata.ZeroAndOne("10"));

            Assert.AreEqual(2, kata.ZeroAndOne("110110"));

            Assert.AreEqual(2, kata.ZeroAndOne("110100"));

        }
    }
}
