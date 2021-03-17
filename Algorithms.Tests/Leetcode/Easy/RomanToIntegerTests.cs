using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Leetcode.Easy
{
    [TestClass]
    public class RomanToIntegerTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(string s, int expected)
        {
            var solution = new Algorithms.Leetcode.Easy.RomanToInteger.RomanToInteger();
            var actual = solution.FirstTry(s, expected);

            Assert.AreEqual(expected, actual);
        }

       

        public static IEnumerable<object[]> Data()
        {
            return new Algorithms.Leetcode.Easy.RomanToInteger.RomanToInteger().Data();
        }
    }
}
