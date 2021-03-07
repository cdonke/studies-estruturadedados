using BenchmarkDotNet.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.BitOperations
{
    //[TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int A, int B)
        {
            long expected = A * B;

            var solution = new Algorithms.BitOperations.Multiplication.Multiplication();
            var actual = solution.FirstTry(A, B);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(int A, int B)
        {
            long expected = A * B;
            var solution = new Algorithms.BitOperations.Multiplication.Multiplication();
            long actual = solution.SecondTry(A, B);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            var solution = new Algorithms.BitOperations.Multiplication.Multiplication();
            var data = solution.Data();

            foreach (var item in data)
            {
                yield return item;
            }
        }

        public static IEnumerable<object[]> Data1()
        {
            var solution = new Algorithms.BitOperations.Multiplication.Multiplication();
            var data = solution.Data1();

            foreach (var item in data)
            {
                yield return item;
            }
        }
    }
}
