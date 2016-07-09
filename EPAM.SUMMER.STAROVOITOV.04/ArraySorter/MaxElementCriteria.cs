using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    public class MaxElementCriteria : ISortCriteria
    {
        public int[] ToCriteriaArray(int[][] jaggedArray)
        {
            int[] result = new int[jaggedArray.Length];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                result[i] = jaggedArray[i].Max();
            }
            return result;
        }
    }
}
