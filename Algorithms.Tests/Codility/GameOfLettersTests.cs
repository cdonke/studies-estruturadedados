using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Codility
{
    [TestClass]
    public class GameOfLettersTests
    {
        [TestMethod]
        [DataRow("cdeo", new[] { 3, 2, 0, 1 }, "code")]
        [DataRow("bytdag", new[] { 4, 3, 0, 1, 2, 5 }, "bat")]
        public void FirstTry(string S, int[] A, string expected)
        {
            var solution = new Algorithms.Codility.GameOfLetters.GameOfLetters();
            var actual = solution.FirstTry(S, A);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("cdeo", new[] { 3, 2, 0, 1 }, "code")]
        [DataRow("bytdag", new[] { 4, 3, 0, 1, 2, 5 }, "bat")]
        public void SecondTry(string S, int[] A, string expected)
        {
            var solution = new Algorithms.Codility.GameOfLetters.GameOfLetters();
            var actual = solution.SecondTry(S, A);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("cdeo", new[] { 3, 2, 0, 1 }, "code")]
        [DataRow("bytdag", new[] { 4, 3, 0, 1, 2, 5 }, "bat")]
        public void ThirdTry(string S, int[] A, string expected)
        {
            var solution = new Algorithms.Codility.GameOfLetters.GameOfLetters();
            var actual = solution.ThirdTry(S, A);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow("cdeo", new[] { 3, 2, 0, 1 }, "code")]
        [DataRow("bytdag", new[] { 4, 3, 0, 1, 2, 5 }, "bat")]
        public void FourthTry(string S, int[] A, string expected)
        {
            var solution = new Algorithms.Codility.GameOfLetters.GameOfLetters();
            var actual = solution.FourthTry(S, A);

            Assert.AreEqual(expected, actual);
        }
    }
}
