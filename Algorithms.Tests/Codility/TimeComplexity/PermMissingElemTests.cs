using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.Codility.TimeComplexity
{
    [TestClass]
    public class PermMissingElemTests
    {
        [TestMethod]
        [DataRow(100100, 10001)]
        [DataRow(100100, 1)]
        [DataRow(100100, 12345)]
        //[DataRow(10, 6)]
        public void FirstTry(int N, int missing)
        {
            var solution = new Algorithms.Codility.TimeComplexity.PermMissingElem.PermMissingElem();

            var range = (from q in Enumerable.Range(1, N)
                         where q != missing
                         select q).ToArray();

            var actual = solution.FirstTry(range);

            Assert.AreEqual(actual, missing);
        }

        [TestMethod]
        [DataRow(100_000, 10_001)]
        [DataRow(100_000, 1)]
        [DataRow(100_000, 12_345)]
        [DataRow(5, 4)]
        //[DataRow(10, 6)]
        public void SecondTry(int N, int missing)
        {
            var solution = new Algorithms.Codility.TimeComplexity.PermMissingElem.PermMissingElem();

            var range = (from q in Enumerable.Range(1, N)
                         where q != missing
                         select q).ToArray();

            var actual = solution.SecondTry(range);

            Assert.AreEqual(N - 1, range.Length);
            Assert.AreEqual(actual, missing);
        }

        [TestMethod]
        [DataRow(100_000, 10_001)]
        [DataRow(100_000, 1)]
        [DataRow(100_000, 12_345)]
        [DataRow(5, 4)]
        //[DataRow(10, 6)]
        public void ThirdTry(int N, int missing)
        {
            var solution = new Algorithms.Codility.TimeComplexity.PermMissingElem.PermMissingElem();

            var range = (from q in Enumerable.Range(1, N)
                         where q != missing
                         select q).ToArray();

            var actual = solution.ThirdTry(range);

            Assert.AreEqual(N - 1, range.Length);
            Assert.AreEqual(missing, actual);
        }
    }
}
