using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility.Arrays
{
    [TestClass]
    public class OddOccurrencesInArrayTests
    {
        [TestMethod]
        [DataRow(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        public void FirstTry(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.Arrays.OddOccurrencesInArray.OddOccurrencesInArray();
            var actual = solution.FirstTry(A);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        public void SecondTry(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.Arrays.OddOccurrencesInArray.OddOccurrencesInArray();
            var actual = solution.SecondTry(A);

            Assert.AreEqual(expected, actual);
        }
    }
}
