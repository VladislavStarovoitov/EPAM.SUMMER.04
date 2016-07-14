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
        private class Comparer: IComparer<int[]>
        {
            private Func<int[], int[], int> _comparer;

            public Comparer(Func<int[], int[], int> comparer)
            {
                _comparer = comparer;
            }

            public int Compare(int[] x, int[] y)
            {
                return _comparer(x, y); 
            }
        }

        /// <summary>
        /// Sort rows of jagged array by criterion and direction.
        /// </summary>
        /// <param name="jaggedArray">Jagged array to sort.</param>
        /// <param name="comparer">The IComparer<int[]> implementation to use when comparing elements.</param>
        public static void SortJaggedArray(int[][] jaggedArray, IComparer<int[]> comparer)
        {
            if (comparer == null || jaggedArray == null)
            {
                throw new ArgumentNullException("comparer");
            }            
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1 - i; j++)
                {
                    if (comparer.Compare(jaggedArray[j], jaggedArray[j + 1]) > 0) 
                    {
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Sort rows of jagged array by criterion and direction.
        /// </summary>
        /// <param name="jaggedArray">Jagged array to sort.</param>
        /// <param name="comparer">Delegate comparer that represents the method that compare elements.</param>
        public static void SortJaggedArray(int[][] jaggedArray, Func<int[], int[], int> comparer)
        {
            SortJaggedArray(jaggedArray, new Comparer(comparer));
        }

        private static void Swap(ref int[] left, ref int[] right)
        {
            int[] temp; 
            temp = left;
            left = right;
            right = temp;
        }
    }
}
