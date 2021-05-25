using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Arrays
{
    //[TestClass]
    public class CountInversionTests
    {
        //[TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int[] A, int expected)
        {
            var solution = new Algorithms.Arrays.CountInversions.CountInversions();
            var actual = solution.FirstTry(A, expected);

            Assert.AreEqual(expected, actual);
        }


        public static IEnumerable<object[]> Data()
        {
            var solution = new Algorithms.Arrays.CountInversions.CountInversions();

            return solution.Data();
        }
    }
}
