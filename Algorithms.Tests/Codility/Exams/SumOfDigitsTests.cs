using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility.Exams
{
    [TestClass]
    public class SumOfDigitsTests
    {
        [TestMethod]
        [DataRow(14, 19)]
        [DataRow(10, 11)]
        [DataRow(99, 9999)]
        public void FirstTry(int N, int expected)
        {
            var solution = new Algorithms.Codility.Exams.SumOfDigits.SumOfDigits();
            var actual = solution.FirstTry(N);

            Assert.AreEqual(expected, actual);
        }
    }
}
