using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    /// <summary>
    /// Exposes a method that create array with sort criteria.
    /// </summary>
    public interface ISortCriteria: IComparer<int>
    {
        int[] ToCriteriaArray(int[][] jaggedArray);
    }
}
