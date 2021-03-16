using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting
{
    [TestClass]
    public class ShellSortTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int[] A)
        {
            var expected = (int[])A.Clone();
            Array.Sort(expected);

            var solution = new Algorithms.Sorting.ShellSort();
            var actual = solution.FirstTry(A);

            CollectionAssert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new[] { new int[] { 1 } };
            yield return new[] { new int[] { 2, 1 } };
            yield return new[] { new int[] { 2, 1, 3 } };
            yield return new[] { new int[] { 1, 1, 1 } };
            yield return new[] { new int[] { 2, -1, 3, 3 } };
            yield return new[] { new int[] { 4, -5, 3, 3 } };
            yield return new[] { new int[] { 0, -5, 3, 3 } };
            yield return new[] { new int[] { 0, -5, 3, 0 } };
            yield return new[] { new int[] { 3, 2, 5, 5, 1, 0, 7, 8 } };
        }
    }
}
