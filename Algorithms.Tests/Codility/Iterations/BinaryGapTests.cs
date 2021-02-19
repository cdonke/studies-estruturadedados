using Algorithms.Codility.Iterations.BinaryGap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility.Iterations
{
    [TestClass]
    public class BinaryGapTests
    {
        [TestMethod]
        [DataRow(9, 2)] //1001
        [DataRow(529, 4)] //1000010001
        [DataRow(20, 1)] //10100 

        [DataRow(1, 0)] //0001 
        [DataRow(2, 0)] //0010 
        [DataRow(147, 2)] //1001 0011 
        [DataRow(483, 3)] //1 1110 0011
        [DataRow(647, 4)] //10 1000 0111 

        [DataRow(32, 0)] //10 0000

        public void FirstTry(int N, int expected)
        {
            var solution = new Algorithms.Codility.Iterations.BinaryGap.FirstTry.Solution();
            var actual = solution.solution(N);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(9, "1001")]
        [DataRow(529, "1000010001")]
        [DataRow(172, "10101100")]
        public void BinaryConverter_Tests(int N, string expected)
        {
            var bin = BinaryConverter.Convert(N);

            var actual = new StringBuilder(bin.Count);
            while (bin.Count > 0)
                actual.Append(bin.Pop());

            Assert.AreEqual(expected, actual.ToString());
        }
    }
}
