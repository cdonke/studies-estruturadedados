using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility.TimeComplexity
{
    [TestClass]
    public class FrogJmpTests
    {
        [TestMethod]
        [DataRow(10,85,30, 3)]
        public void FirstTry(int X, int Y, int D, int expected)
        {
            var solution = new Algorithms.Codility.TimeComplexity.FrogJmp.FrogJmp();
            var actual = solution.FirstTry(X, Y, D);

            Assert.AreEqual(actual, expected);
        }
    }
}
