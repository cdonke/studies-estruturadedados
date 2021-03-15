using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Arrays
{
    [TestClass]
    public class FindEquilibriumTests
    {
        [TestMethod]
        [DataRow(new int[] { 0, -3, 5, -4, -2, 3, 1, 0 }, new int[] { 0, 3, 7 } )]
        public void FirstTry(int[] A, int[] expected)
        {
            var solution = new Algorithms.Arrays.FindEquilibrium.FindEquilibrium();
            var actual = solution.FirstTry(A);

            CollectionAssert.AreEqual(expected, actual);
        }       
    }
}
