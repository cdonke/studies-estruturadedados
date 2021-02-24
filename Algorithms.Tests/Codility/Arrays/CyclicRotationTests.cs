using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.Codility.Arrays
{
    [TestClass]
    public class CyclicRotationTests
    {
        [TestMethod]
        [DataRow(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [DataRow(new int[] { 0, 0, 0 }, 1, new int[] { 0, 0, 0 })]
        [DataRow(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        public void FirstTry(int[] A, int K, int[] expected)
        {
            var solution = new Algorithms.Codility.Arrays.CyclicRotation.CyclicRotation();
            var actual = solution.FirstTry(A, K);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [DataRow(new int[] { 0, 0, 0 }, 1, new int[] { 0, 0, 0 })]
        [DataRow(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        public void SecondTry(int[] A, int K, int[] expected)
        {
            var solution = new Algorithms.Codility.Arrays.CyclicRotation.CyclicRotation();
            var actual = solution.SecondTry(A, K);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(new int[] { 1, 2, 3 }, -1)]
        [DataRow(new int[] { 1, 2, 3 }, 101)]
        [DynamicData(nameof(OversizedArray), DynamicDataSourceType.Property)]
        public void FirstTry_Exceptions(int[] A, int K)
        {
            var solution = new Algorithms.Codility.Arrays.CyclicRotation.CyclicRotation();
            var actual = solution.FirstTry(A, K);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(new int[] { 1, 2, 3 }, -1)]
        [DataRow(new int[] { 1, 2, 3 }, 101)]
        [DynamicData(nameof(OversizedArray), DynamicDataSourceType.Property)]

        public void SecondTry_Exceptions(int[] A, int K)
        {
            var solution = new Algorithms.Codility.Arrays.CyclicRotation.CyclicRotation();
            var actual = solution.SecondTry(A, K);
        }

        public static IEnumerable<object[]> OversizedArray =>
            new[] { new object[] { Enumerable.Range(0, 101).ToArray(), 1} };
    }
}
