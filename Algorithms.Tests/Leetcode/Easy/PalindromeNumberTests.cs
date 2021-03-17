using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Leetcode.Easy
{
    [TestClass]
    public class PalindromeNumberTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int x, bool expected)
        {
            var solution = new Algorithms.Leetcode.Easy.PalindromeNumber.PalindromeNumber();
            var actual = solution.FirstTry(x, expected);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(int x, bool expected)
        {
            var solution = new Algorithms.Leetcode.Easy.PalindromeNumber.PalindromeNumber();
            var actual = solution.SecondTry(x, expected);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            return new Algorithms.Leetcode.Easy.PalindromeNumber.PalindromeNumber().Data();
        }
    }
}
