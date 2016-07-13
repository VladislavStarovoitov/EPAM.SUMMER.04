using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Linq;
using ArraySorter;

namespace ArraySorter.Tests
{
    [TestClass]
    public class ArraySorterTests
    {
        [TestMethod]
        public void SortBySumAsc()
        {
            int[][] testArray = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 4, 15, 9 } };
            int[][] sortedArray = new int[3][] { new int[] { 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 4, 15, 9 } };
            var comparer = new SumAscComparer();

            JaggedArraySorter.SortJaggedArray(testArray, comparer);

            CollectionAssert.AreEqual(testArray, sortedArray, new Comparer());
        }

        [TestMethod]
        public void SortBySumDsc()
        {
            int[][] testArray = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 4, 15, 9 } };
            int[][] sortedArray = new int[3][] { new int[] { 4, 15, 9 }, new int[] { 1, 2, 3 }, new int[] { 1, 2 }, };
            var comparer = new SumDscComparer();

            JaggedArraySorter.SortJaggedArray(testArray, comparer);

            CollectionAssert.AreEqual(testArray, sortedArray, new Comparer());
        }

        [TestMethod]
        public void SortByAbsMaxDsc()
        {
            int[][] testArray = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 4, 15, 9 } };
            int[][] sortedArray = new int[3][] { new int[] { 4, 15, 9 }, new int[] { 1, 2, 3 }, new int[] { 1, 2 }, };
            var comparer = new AbsMaxDscComparer();

            JaggedArraySorter.SortJaggedArray(testArray, comparer);

            CollectionAssert.AreEqual(testArray, sortedArray, new Comparer());
        }

        [TestMethod]
        public void SortByAbsMaxAsc()
        {
            int[][] testArray = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 4, 15, 9 } };
            int[][] sortedArray = new int[3][] { new int[] { 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 4, 15, 9 } };
            var comparer = new AbsMaxAscComparer();

            JaggedArraySorter.SortJaggedArray(testArray, comparer);

            CollectionAssert.AreEqual(testArray, sortedArray, new Comparer());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Sort_CriteriaIsNull_ArgumentNullException()
        {
            int[][] testArray = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1, 2, 0 }, new int[] { 4, 15, 9 } };

            JaggedArraySorter.SortJaggedArray(testArray, null);
        }
    }


    public class Comparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var first = (int[])x;
            var second = (int[])y;

            if (first.Sum() > second.Sum())
            {
                return 1;
            }
            if (first.Sum() < second.Sum())
                return -1;
            return 0;
        }
    }
}
