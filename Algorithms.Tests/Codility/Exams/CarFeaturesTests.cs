using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility.Exams
{
    [TestClass]
    public class CarFeaturesTests
    {
        [TestMethod]
        [DataRow(new[] { "100", "110", "010", "011", "100" }, new[] { 2, 3, 2, 1, 2 })]
        public void FirstTry(string[] cars, int[] expected)
        {
            var solution = new Algorithms.Codility.Exams.CarFeatures.CarFeatures();
            var actual = solution.FirstTry(cars);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new[] { "100", "110", "010", "011", "100" }, new[] { 2, 3, 2, 1, 2 })]
        public void SecondTry(string[] cars, int[] expected)
        {
            var solution = new Algorithms.Codility.Exams.CarFeatures.CarFeatures();
            var actual = solution.SecondTry(cars);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
