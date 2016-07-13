using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter.Tests
{
    class AbsMaxAscComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            int maxX = Math.Abs(x.Max());
            int maxY = Math.Abs(y.Max());
            if (maxX > maxY)
                return 1;
            if (maxX < maxY)
                return -1;
            return 0;
        }
    }
}
