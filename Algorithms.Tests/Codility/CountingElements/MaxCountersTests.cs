using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility.CountingElements
{
    [TestClass]
    public class MaxCountersTests
    {
        [TestMethod]
        [DataRow(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 })]
        public void FirstTry(int N, int[] A, int[] expected)
        {
            var solution = new Algorithms.Codility.CountingElements.MaxCounters.MaxCounters();

            var actual = solution.FirstTry(N, A);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 })]
        public void SecondTry(int N, int[] A, int[] expected)
        {
            var solution = new Algorithms.Codility.CountingElements.MaxCounters.MaxCounters();

            var actual = solution.SecondTry(N, A);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 })]
        public void ThirdTry(int N, int[] A, int[] expected)
        {
            var solution = new Algorithms.Codility.CountingElements.MaxCounters.MaxCounters();

            var actual = solution.ThirdTry(N, A);

            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        //[DataRow(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 })]
        [DataRow(5, new int[] { 1, 2, 3, 4, 5, 1, 1, 1, 1, 1, 1, 1, 1, 6, 6, 6, 6, 6, 6 }, new int[] { 9, 9, 9, 9, 9 })]
        public void FourthTry(int N, int[] A, int[] expected)
        {
            var solution = new Algorithms.Codility.CountingElements.MaxCounters.MaxCounters();

            var actual = solution.FourthTry(N, A);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
