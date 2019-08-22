using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    public class ComplementaryDnaTests
    {
        [TestCase("ATTGC", "TAACG")]
        [TestCase("GTAT", "CATA")]
        [TestCase("TTTT", "AAAA")]
        [TestCase("TAACG", "ATTGC")]
        [TestCase("CATA", "GTAT")]
        public void MakeComplement(string dna, string expected)
        {
            var actual = ComplementaryDnaKata.MakeComplement(dna);

            Assert.AreEqual(expected, actual);
        }
    }
}