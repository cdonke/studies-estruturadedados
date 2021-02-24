using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility.CountingElements
{
    [TestClass]
    public class FrogRiverOneTests
    {
        [TestMethod]
        [DataRow(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
        [DataRow(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
        [DataRow(5, new int[] { 1, 3, 1, 4, 2, 3, 4, 4 }, -1)]
        public void FirstTry(int X, int[] A, int expected)
        {
            var solution = new Algorithms.Codility.CountingElements.FrogRiverOne.FrogRiverOne();

            var actual = solution.FirstTry(X, A);

            Assert.AreEqual(expected, actual);
        }
    }
}
