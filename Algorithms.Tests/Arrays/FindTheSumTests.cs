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
        public void FirstTry(int[] A, int sum)
        {
            var solution = new Algorithms.Arrays.FindTheSum.FindTheSum();
            var actual = solution.FirstTry(A, sum);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(int[] A, int sum)
        {
            var solution = new Algorithms.Arrays.FindTheSum.FindTheSum();
            var actual = solution.SecondTry(A, sum);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void ThirdTry(int[] A, int sum)
        {
            var solution = new Algorithms.Arrays.FindTheSum.FindTheSum();
            var actual = solution.ThirdTry(A, sum);

            Assert.IsTrue(actual);
        }

        public static IEnumerable<object[]> Data()
        {
            var solution = new Algorithms.Arrays.FindTheSum.FindTheSum();
            foreach (object[] item in solution.Data())
                yield return item;
        }
    }
}
