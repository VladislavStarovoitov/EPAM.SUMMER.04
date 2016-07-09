using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    public interface ISortCriteria
    {
        int[] ToCriteriaArray(int[][] jaggedArray);
    }
}
