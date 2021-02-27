using Microsoft.Diagnostics.Tracing.Parsers.Symbol;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.Sorting
{
    [TestClass]
    public class HeapSortTests
    {
        [TestMethod]
        [DynamicData(nameof(data), DynamicDataSourceType.Method)]
        [DynamicData(nameof(largeData), DynamicDataSourceType.Method)]
        public void HeapSort(int[] A)
        {
            var expected = A.Clone() as int[];
            Array.Sort(expected);

            var heapsort = new Algorithms.Sorting.HeapSort();
            var actual = heapsort.Sort(A);

            CollectionAssert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> largeData()
        {
            var solution = new Algorithms.Sorting.HeapSort();
            var data = solution.Data();
            foreach (object[] item in data)
            {
                var lstData = new List<int>();
                foreach (int el in item)
                    lstData.Add(el);

                yield return new object[] { lstData.ToArray() };
            };
        }


        public static IEnumerable<object[]> data()
        {
            return new[]
            {
                new object[] { new int[] {  4,1,3,2,16,9,10,14,8,7  } },
                new object[] { new int[] { 23, 4, 67, -8, 90, 54, 21 } }
            };
        }
    }
}
