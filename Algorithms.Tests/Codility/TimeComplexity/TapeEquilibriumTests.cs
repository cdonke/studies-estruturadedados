using BenchmarkDotNet.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility.TimeComplexity
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        [TestMethod]
        [DataRow(new int[] { 3, 1, 2, 4, 3 }, 1)]
        public void FirstTry(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.TimeComplexity.TapeEquilibrium.TapeEquilibrium();

            var actual = solution.FirstTry(A);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 1, 2, 4, 3 }, 1)]
        public void FirstTry_BitwiseAbs(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.TimeComplexity.TapeEquilibrium.TapeEquilibrium();

            var actual = solution.FirstTry_BitwiseAbs(A);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow(new int[] { 3, 1, 2, 4, 3 }, 1)]
        public void SecondTry(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.TimeComplexity.TapeEquilibrium.TapeEquilibrium();

            var actual = solution.SecondTry(A);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 1, 2, 4, 3 }, 1)]
        public void SecondTry_BitwiseAbs(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.TimeComplexity.TapeEquilibrium.TapeEquilibrium();

            var actual = solution.SecondTry_BitwiseAbs(A);

            Assert.AreEqual(expected, actual);
        }
    }
}
