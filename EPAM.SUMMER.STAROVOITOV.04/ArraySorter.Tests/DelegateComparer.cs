using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter.Tests
{
    public static class DelegateComparer
    {
        public static int SortBySumAsc(int[] x, int[] y)
        {
            if (x.Sum() > y.Sum())
                return 1;
            if (x.Sum() < y.Sum())
                return -1;
            return 0;
        }
    }
}
