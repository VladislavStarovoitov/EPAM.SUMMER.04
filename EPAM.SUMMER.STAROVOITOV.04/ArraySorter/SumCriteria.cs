using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    public class SumCriteria : ISortCriteria
    {
        /// <summary>
        /// Create array with sum of jagged array's rows.
        /// </summary>
        /// <param name="jaggedArray">Array to sort.</param>
        /// <returns>Array with rows sum.</returns>
        public int[] ToCriteriaArray(int[][] jaggedArray)
        {
            int[] result = new int[jaggedArray.Length];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                result[i] = jaggedArray[i].Sum();
            }
            return result;
        }
    }
}
