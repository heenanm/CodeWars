using System.Collections.Generic;
using System.Linq;

namespace CodeWars._8kyu
{
    public class ComplementaryDnaKata
    {
        private static readonly Dictionary<char, string> _lookup;

        static ComplementaryDnaKata()
        {
            _lookup = new Dictionary<char, string>
            {
                {'A', "T"},
                {'C', "G"},
                {'T', "A"},
                {'G', "C"}
            };
        }

        public static string MakeComplement(string dna)
        {
            return string.Concat(dna.Select(x => _lookup[x]));
        }

        //public static string MakeComplement(string dna)
        //{
        //    var temp = new StringBuilder();

        //    for (var i = 0; i < dna.Length; i++)
        //    {
        //        temp.Append(_lookup[dna[i]]);               
        //    }

        //    return temp.ToString();
        //}
    }
}