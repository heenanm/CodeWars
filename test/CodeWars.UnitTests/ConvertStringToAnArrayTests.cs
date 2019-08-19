using NUnit.Framework;

namespace CodeWars.UnitTests
{
    class ConvertStringToAnArrayTests
    {
        [TestCase("Robin Singh", new string[] { "Robin", "Singh" })]
        [TestCase("I love arrays they are my favorite", new string[] { "I", "love", "arrays", "they", "are", "my", "favorite" })]
        public void StringToArray(string str, string[] expected)
        {
            var actual = ConvertStringToAnArray.StringToArray(str);

            Assert.AreEqual(expected, actual);
        }
    }
}
