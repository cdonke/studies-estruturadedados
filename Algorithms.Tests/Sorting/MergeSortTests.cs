using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Runtime.DacInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting
{
    [TestClass]
    public class MergeSortTests
    {

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int[] A)
        {
            int[] expected = (int[])A.Clone();
            Array.Sort(expected);

            var solution = new Algorithms.Sorting.MergeSort();
            var actual = solution.FirstTry(A);

            CollectionAssert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            return Algorithms.Sorting.MergeSort.Data();
        }
    }
}
