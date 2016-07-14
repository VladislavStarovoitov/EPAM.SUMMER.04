using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ArraySorter.Tests
{
    [TestFixture]
    class ArraySorterNextTests
    {
        [TestCaseSource(typeof(DataProvider), nameof(DataProvider.GetArrayForSortingBySumAscWithDelegateComparer))]
        public void SortBySumAscWithDelegateComparer(int[][] testArray, int[][] sortedArray)
        {
            Func<int[], int[], int> comparer = DelegateComparer.SortBySumAsc;

            JaggedArraySorterNext.SortJaggedArray(testArray, comparer);

            CollectionAssert.AreEqual(sortedArray, testArray);
        }

        [TestCaseSource(typeof(DataProvider), nameof(DataProvider.GetArrayForSortingBySumAscWithDelegateComparer))]
        public void SortBySumAscWithInterfaceComparer(int[][] testArray, int[][] sortedArray)
        {
            var comparer = new SumAscComparer();

            JaggedArraySorterNext.SortJaggedArray(testArray, comparer);

            CollectionAssert.AreEqual(sortedArray, testArray);
        }

        public static class DataProvider
        {
            public static IEnumerable GetArrayForSortingBySumAscWithDelegateComparer()
            {
                yield return new TestCaseData(new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 4, 15, 9 } },
                                              new int[3][] { new int[] { 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 4, 15, 9 } });
            }
        }
    }
}
