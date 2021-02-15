using Algorithms.Searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Searching
{
    [TestClass]
    public class SequentialSearchTests
    {
        [TestMethod]
        [DataRow(new[] { 11, 12, 23, 27, 33, 43, 56, 76, 87, 96 }, 12, 1)]
        [DataRow(new[] { 11, 12, 23, 27, 33, 43, 56, 76, 87, 96 }, 87, 8)]
        [DataRow(new[] { 11, 12, 23, 27, 33, 43, 56, 76, 87, 96 }, 99, -1)]
        public void Search(int[] data, int value, int expected)
        {
            var search = new SequentialSearch(data);
            var idx = search.Search(value);

            Assert.AreEqual(expected, idx);
        }
    }
}
