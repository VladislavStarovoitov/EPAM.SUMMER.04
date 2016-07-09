using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    public static class JaggedArraySorter
    {
        public static void SortJaggedArray(int[][] jaggedArray, ISortCriteria criteria, Direction direction)
        {
            int[] criteriaArray = criteria.ToCriteriaArray(jaggedArray);            
            for (int i = 0; i < criteriaArray.Length - 1; i++)
            {
                for (int j = 0; j < criteriaArray.Length - 1 - i; j++)
                {
                    if (criteriaArray[j] > criteriaArray[j + 1] ^ direction == Direction.Ascending)
                    {
                        Swap(ref criteriaArray[j], ref criteriaArray[j + 1]);
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        private static void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }
    }
}
