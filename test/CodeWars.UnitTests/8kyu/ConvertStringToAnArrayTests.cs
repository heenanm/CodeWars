using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    internal class ConvertStringToAnArrayTests
    {
        [TestCase("Robin Singh", new[] {"Robin", "Singh"})]
        [TestCase("I love arrays they are my favorite", new[] {"I", "love", "arrays", "they", "are", "my", "favorite"})]
        public void StringToArray(string str, string[] expected)
        {
            var actual = ConvertStringToAnArrayKata.StringToArray(str);

            Assert.AreEqual(expected, actual);
        }
    }
}