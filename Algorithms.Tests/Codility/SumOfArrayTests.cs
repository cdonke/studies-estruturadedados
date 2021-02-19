using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.Codility
{
    [TestClass]
    public class SumOfArrayTests
    {
       
        [TestMethod]
        [DataRow(4)]
        [DataRow(3)]
        [DataRow(10)]
        [DataRow(2)]
        [DataRow(70)]
        [DataRow(20)]
        public void FirstTry_Tests(int N)
        {
            var solution = new Algorithms.Codility.Exams.SumOfArray.SumOfArray();

            var result = solution.FirstTry(N);

            var sum = 0;
            foreach (var item in result)
            {
                sum += item;
                Console.WriteLine(item);
            }

            Assert.AreEqual(0, sum);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(101)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FirstTry_OutOfRange_Tests(int N)
        {
            var solution = new Algorithms.Codility.Exams.SumOfArray.SumOfArray();
            var result = solution.FirstTry(N);
        }
    }
}