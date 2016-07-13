using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    /// <summary>
    /// Contains methods to sort rows of jagged array.
    /// </summary>
    public static class JaggedArraySorter
    {
        /// <summary>
        /// Sort rows of jagged array by criterion and direction.
        /// </summary>
        /// <param name="jaggedArray">Jagged array to sort.</param>
        /// <param name="criteria">The ISortCriteria implementation to use when creating array of criteria.</param>
        /// <param name="direction">Sorting direction.</param>
        public static void SortJaggedArray(int[][] jaggedArray, IComparer<int[]> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException("comparer");
            }            
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1 - i; j++)
                {
                    if (comparer.Compare(jaggedArray[j], jaggedArray[j + 1]) > 0)
                    {
                        Swap(jaggedArray[j],jaggedArray[j + 1]);
                    }
                }
            }
        }

        private static void Swap(int[] left, int[] right)
        {
            int[] temp;
            temp = left;
            left = right;
            right = temp;
        }
    }
}
