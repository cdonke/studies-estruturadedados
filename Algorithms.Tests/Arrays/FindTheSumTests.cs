using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Arrays
{
    [TestClass]
    public class FindTheSumTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int[] A, int sum, bool expected)
        {
            var solution = new Algorithms.Arrays.FindTheSum.FindTheSum();
            var actual = solution.FirstTry(A, sum);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(int[] A, int sum, bool expected)
        {
            var solution = new Algorithms.Arrays.FindTheSum.FindTheSum();
            var actual = solution.SecondTry(A, sum);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void ThirdTry(int[] A, int sum, bool expected)
        {
            var solution = new Algorithms.Arrays.FindTheSum.FindTheSum();
            var actual = solution.ThirdTry(A, sum);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            var solution = new Algorithms.Arrays.FindTheSum.FindTheSum();
            foreach (object[] item in solution.Data())
                yield return new object[] { item[0], item[1], true };

            yield return new object[] { new int[] { 10, 5 }, 0, false };
            yield return new object[] { new int[] { 1, 9, 19, 5 }, 10 , true };
        }
    }
}
