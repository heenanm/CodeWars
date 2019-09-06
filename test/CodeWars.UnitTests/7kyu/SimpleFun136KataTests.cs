using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars._7kyu;


namespace CodeWars.UnitTests._7kyu
{
    [TestFixture]
    class SimpleFun136KataTests
    {
        public int An(int[] arr)
        {
            var a = arr.OrderBy(x => x).ToArray();
            double r = 1;
            var h = new Dictionary<int, int>();
            foreach (int n in a)
            {
                r = h.ContainsKey(n) ? r / n : r * n * n;
                if (h.ContainsKey(n)) h[n]++;
                else h.Add(n, 1);
            }
            return (int)r;
        }

        public int[] rndtest()
        {
            int len = rand(3, 30), n = rand(1, 500);
            var r = new List<int>();
            for (var i = 0; i < len; i++, n += rand(1, 5))
            {
                r.Add(n);
                r.Add(n);
                r.Add(n);
            }
            int idx = rand(0, r.Count - 1), x = r[idx];
            r.RemoveAt(idx);
            if (idx < r.Count - 1 && r[idx] == x) r.RemoveAt(idx);
            else r.RemoveAt(idx - 1);
            idx = rand(0, r.Count - 1);
            while (r[idx] == x) idx = rand(0, r.Count - 1);
            r.RemoveAt(idx);
            shuff(r);
            return r.ToArray();
        }

        //Tools
        public void shuff(List<int> r)
        {
            for (int i = 0; i < 50; i++)
            {
                int idx1 = rand(0, r.Count - 1), idx2 = rand(0, r.Count - 1);
                var tt = r[idx1];
                r[idx1] = r[idx2];
                r[idx2] = tt;
            }
        }
        public string repeat(string c, int n)
        {
            var s = new string('&', n);
            return Regex.Replace(s, "&", c);
        }


        Random rndnum = new Random(unchecked((int)DateTime.Now.Ticks));
        public int rand(int a, int b)
        {
            return a > b ? rand(b, a) : rndnum.Next(a, b + 1);
        }
        public string rnds(int n)
        {
            var len = n;
            var rs = new List<char>();
            for (int i = 0; i < len; i++) rs.Add(rndcl());
            return string.Join("", rs);
        }
        public string rndss(int n)
        {
            var len = n;
            var rs = new List<string>();
            for (int i = 0; i < len; i++) rs.Add(rnds(rand(3, 7)));
            return string.Join(" ", rs);
        }
        public string rnds2(int n)
        {
            var len = n;
            var rs = new List<char>();
            for (int i = 0; i < len; i++) rs.Add(rndch());
            return string.Join("", rs);
        }
        public char rndcl()
        {
            var allc = "abcdefghijklmnopqrstuvwxyz";
            return allc[rand(0, allc.Length - 1)];
        }
        public char rndchl()
        {
            var allc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return allc[rand(0, allc.Length - 1)];
        }
        public char rndch()
        {
            var allc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return allc[rand(0, allc.Length - 1)];
        }
        [Test]
        public void Test1__Basic_Tests()
        {
            var kata = new SimpleFun136Kata();
            var passed = "<font size=2 color='#8FBC8F'>Test Passed!</font>\n";

            Assert.AreEqual(18, kata.MissingValues(new int[] { 1, 1, 1, 2, 2, 3 }));
            Console.WriteLine(passed);
            Assert.AreEqual(12096, kata.MissingValues(new int[] { 96, 56, 24, 46, 75, 46, 75, 21, 46, 21, 75, 96, 56, 96, 56 }));
            Console.WriteLine(passed);
            Assert.AreEqual(28431, kata.MissingValues(new int[] { 27, 65, 44, 39, 44, 21, 21, 44, 65, 39, 21, 65 }));
            Console.WriteLine(passed);
            Assert.AreEqual(18411, kata.MissingValues(new int[] { 66, 4, 80, 66, 4, 83, 97, 81, 19, 4, 80, 51, 83, 81, 83, 66, 51, 80, 97, 81, 97 }));
            Console.WriteLine(passed);
            Assert.AreEqual(249704, kata.MissingValues(new int[] { 60, 76, 86, 76, 86, 53, 60, 88, 71, 71, 71, 86, 88, 76, 88, 17, 60, 26, 17, 17, 26, 53, 98, 53 }));
            Console.WriteLine(passed);
            Assert.AreEqual(192375, kata.MissingValues(new int[] { 42, 23, 45, 33, 33, 19, 42, 79, 79, 23, 95, 95, 79, 19, 42, 33, 19, 23 }));
            Console.WriteLine(passed);
            Assert.AreEqual(5915, kata.MissingValues(new int[] { 4, 74, 41, 41, 41, 88, 63, 35, 35, 4, 88, 13, 63, 74, 63, 88, 4, 74 }));
            Console.WriteLine(passed);
            Console.WriteLine(" ");

        }

        [Test]
        public void Test2__100_Random_Tests()
        {
            var kata = new SimpleFun136Kata();
            var passed = "<font size=2 color='#8FBC8F'><b>Test Passed!</b></font>";

            for (int i = 0; i < 100; i++)
            {
                var ab = rndtest();
                //var cd=rand(0,100000);
                Console.WriteLine("<font size=2 color='#CFB53B'>Testing for: " +
                "\narr = new int[]{" + string.Join(", ", ab) + "}"
                //"\nmsg = \""+ab+"\""
                //+", numberOfDigits = "+ab[1]
                //+", loved = "+ab[2]
                //+", s = "+ab[3]
                + "</font>");
                var answer = An(ab);
                Assert.AreEqual(answer, kata.MissingValues(ab));
                Console.WriteLine("<font size=2 color='#8FBC8F'>" +
                "Pass Value = " + answer + "</font>\n");
                Console.WriteLine(" ");
            }

            Console.WriteLine("<div style='width:360px;background-color:gray'><br><font size=2 color='#3300dd'><b>Happy Coding ^_^</b></font>");
            Console.WriteLine("<br><font size=2 color='#5500ee'><b>Thanks for solve this kata,\nI'm waiting for your:<font color='993300'>\nfeedback, voting and ranking ;-)</b></font></div>");

        }
    }
}

