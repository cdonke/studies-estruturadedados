﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Tests.Codility.CountingElements
{
    [TestClass]
    public class PermChecksTests
    {
        // Test Disabled because the try is wrong for outliers
        //[TestMethod]
        //[DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        [ExcludeFromCodeCoverage]
        public void FirstTry(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.CountingElements.PermCheck.PermCheck();
            var actual = solution.FirstTry(A, expected);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.CountingElements.PermCheck.PermCheck();
            var actual = solution.SecondTry(A, expected);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void ThirdTry(int[] A, int expected)
        {
            var solution = new Algorithms.Codility.CountingElements.PermCheck.PermCheck();
            var actual = solution.ThirdTry(A, expected);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            var solution = new Algorithms.Codility.CountingElements.PermCheck.PermCheck();
            var data = solution.Data();

            foreach (object[] item in data)
                yield return item;
        }
    }
}
