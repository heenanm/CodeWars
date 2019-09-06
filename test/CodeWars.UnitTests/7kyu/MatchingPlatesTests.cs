using System;
using System.Linq;
using NUnit.Framework;
using CodeWars._7kyu;

namespace CodeWars.UnitTests._7kyu
{
    [TestFixture]
    public class MatchingPlatesTests
    {
        public bool solution(char[] meals, char[] stack)
        {
            return meals.Count(m => m == 'b') <= stack.Count(m => m == 'b') && meals.Length <= stack.Length;
        }

        [Test]
        public void KataTests()
        {
            Assert.AreEqual(true,
                MatchingPlatesKata.MatchingPlates(new char[] {'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b', 'b'},
                    new char[] {'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b', 'b'}));
            Assert.AreEqual(false,
                MatchingPlatesKata.MatchingPlates(new char[] {'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b', 'b'},
                    new char[] {'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b'}));
            Assert.AreEqual(true, MatchingPlatesKata.MatchingPlates(new char[] { }, new char[] {'b'}));
            Assert.AreEqual(false, MatchingPlatesKata.MatchingPlates(new char[] {'s'}, new char[] { }));
            Assert.AreEqual(true, MatchingPlatesKata.MatchingPlates(new char[] { }, new char[] { }));
        }

        [Test]
        public void randomTests()
        {
            for (int i = 0; i < 5; i++)
            {
                Random r = new Random();
                char[] meals = new char[(int) r.Next(1, 20)];
                char[] stack = new char[(int) r.Next(1, 20)];
                for (int a = 0; a < meals.Length; a++)
                {
                    if ((int) r.Next(1, 2) == 1)
                    {
                        meals[a] = 's';
                    }
                    else
                    {
                        meals[a] = 'b';
                    }
                }

                for (int a = 0; a < stack.Length; a++)
                {
                    if ((int) r.Next(1, 2) == 1)
                    {
                        stack[a] = 's';
                    }
                    else
                    {
                        stack[a] = 'b';
                    }
                }

                Assert.AreEqual(solution(meals, stack), MatchingPlatesKata.MatchingPlates(meals, stack));
            }
        }
    }
}
