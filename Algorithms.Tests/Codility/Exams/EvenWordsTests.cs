using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility.Exams
{
    [TestClass]
    public class EvenWordsTests
    {
        [TestMethod]
        [DataRow("acbcbba", 1)]
        [DataRow("axxaxa", 2)]
        [DataRow("aaaa", 0)]
        public void FirstTry(string S, int expected)
        {
            var solution = new Algorithms.Codility.Exams.EvenWords.EvenWords();
            var actual = solution.FirstTry(S);

            Assert.AreEqual(expected, actual);    
        }
    }
}
