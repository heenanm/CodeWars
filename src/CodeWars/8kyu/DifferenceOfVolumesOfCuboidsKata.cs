using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class DifferenceOfVolumesOfCuboidsKata
    {
        public static int FindDifference(int[] a, int[] b)
        {
            var aVolume = (a[0] * a[1] * a[2]);
            var bVolume = (b[0] * b[1] * b[2]);

            return Math.Max(aVolume, bVolume) - Math.Min(aVolume, bVolume);
        }
    }
}
