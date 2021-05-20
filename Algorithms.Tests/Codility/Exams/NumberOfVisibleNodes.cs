using BenchmarkDotNet.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility.Exams
{
    [TestClass]
    public class NumberOfVisibleNodes
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(Algorithms.Codility.Exams.NumberOfVisibleNodes.NumberOfVisibleNodes.Tree Tree, int expected)
        {
            var solution = new Algorithms.Codility.Exams.NumberOfVisibleNodes.NumberOfVisibleNodes();
            var actual = solution.FirstTry(Tree, 0);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data() =>
            Algorithms.Codility.Exams.NumberOfVisibleNodes.NumberOfVisibleNodes.Data();
    }
}
