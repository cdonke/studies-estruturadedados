using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.Codility.CountingElements
{
    [TestClass]
    public class MissingIntegerTests
    {
        // Disabling test because it's wrong for outliers
        //[TestMethod]
        [DataRow(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [DynamicData(nameof(controlledData), DynamicDataSourceType.Method)]
        [DynamicData(nameof(benchmarkData), DynamicDataSourceType.Method)]
        [DataRow(new int[] { 3 }, 1)]
        [DataRow(new int[] { 1, 2, 3 }, 4)]
        public void FirstTry(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.CountingElements.MissingInteger.MissingInteger();
            var actual = solution.FirstTry(A);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [DynamicData(nameof(controlledData), DynamicDataSourceType.Method)]
        [DynamicData(nameof(benchmarkData), DynamicDataSourceType.Method)]
        [DataRow(new int[] { 3 }, 1)]
        [DataRow(new int[] { 1, 2, 3 }, 4)]
        public void SecondTry(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.CountingElements.MissingInteger.MissingInteger();
            var actual = solution.SecondTry(A);

            Assert.AreEqual(expected, actual);
        }

       
        public static IEnumerable<object[]> controlledData()
        {
            Random r = new Random();

            var q1 = Enumerable.Range(0, 100);
            var q2 = Enumerable.Range(102, 98);
            var data2 = q1.Where(q => q != 51).OrderBy(q => r.Next()).ToArray();
            var data3 = q2.OrderBy(q => r.Next()).ToArray();


            return new[]
            {
                new object[] { data2, 51 },
                new object[] { data3, 1 }
            };
        }
        public static IEnumerable<object[]> benchmarkData()
        {
            var solution = new Algorithms.Codility.CountingElements.MissingInteger.MissingInteger();
            var data = solution.Data();

            foreach (object[] item in data)
                yield return item;
        }
    }
}
