using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Leetcode.Easy
{
    [TestClass]
    public class ReverseIntegerTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int x, int expected)
        {
            var solution = new Algorithms.Leetcode.Easy.ReverseInteger.ReverseInteger();
            var actual = solution.FirstTry(x, expected);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(int x, int expected)
        {
            var solution = new Algorithms.Leetcode.Easy.ReverseInteger.ReverseInteger();
            var actual = solution.SecondTry(x, expected);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void ThirdTry(int x, int expected)
        {
            var solution = new Algorithms.Leetcode.Easy.ReverseInteger.ReverseInteger();
            var actual = solution.ThirdTry(x, expected);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            var solution = new Algorithms.Leetcode.Easy.ReverseInteger.ReverseInteger();
            foreach (object[] item in solution.Data())
                yield return item;
        }
    }
}
