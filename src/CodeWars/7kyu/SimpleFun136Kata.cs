using System.Linq;

namespace CodeWars._7kyu
{
    public class SimpleFun136Kata
    {
        public int MissingValues(int[] arr)
        {
            var requiredSingleInt = arr.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key);
            var requiredDoubleInt = arr.GroupBy(x => x).Where(x => x.Count() == 2).Select(x => x.Key);

            return requiredSingleInt.ElementAt(0) * requiredSingleInt.ElementAt(0) * requiredDoubleInt.ElementAt(0);
        }
    }
}
