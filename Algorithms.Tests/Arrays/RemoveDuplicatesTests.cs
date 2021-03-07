using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Arrays
{
    [TestClass]
    public class RemoveDuplicatesTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int[] A, int[] expected)
        {
            var solution = new Algorithms.Arrays.RemoveDuplicates.RemoveDuplicates();
            var actual = solution.FirstTry(A);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(int[] A, int[] expected)
        {
            var solution = new Algorithms.Arrays.RemoveDuplicates.RemoveDuplicates();
            var actual = solution.SecondTry(A);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void ThirddTry(int[] A, int[] expected)
        {
            var solution = new Algorithms.Arrays.RemoveDuplicates.RemoveDuplicates();
            var actual = solution.ThirdTry(A);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FourthTry(int[] A, int[] expected)
        {
            var solution = new Algorithms.Arrays.RemoveDuplicates.RemoveDuplicates();
            var actual = solution.FourthTry(A);

            CollectionAssert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new[] { new int[] { 1, 2, 2, 6, 6, 8, 9, 10, 10 }, new int[] { 1, 2, 6, 8, 9, 10, 0, 0, 0 } };
            yield return new[] { new int[] { 2, 2, 2, 2, 2, 2 }, new int[] { 2, 0, 0, 0, 0, 0 } };
            yield return new[] { new int[] { 2, 3, 3, 3, 6, 9, 9 }, new int[] { 2, 3, 6, 9, 0, 0, 0 } };
            yield return new[] { new int[] { 2, 2, 2, 11 }, new int[] { 2, 11, 0, 0 } };
        }
    }
}
