using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        [DataRow(new int[] { 25, 57, 48, Int32.MaxValue, Int32.MinValue, 37, 12, 92, 33 }, new int[] { Int32.MinValue, 12, 25, 33, 37, 48, 57, 92, Int32.MaxValue })]
        public void SortWithXOR(int[] data, int[] expected)
        {
            var sort = new Algorithms.Sorting.InsertionSort();
            var actual = sort.SortWithXOR(data);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 25, 57, 48, Int32.MaxValue, Int32.MinValue, 37, 12, 92, 33 }, new int[] { Int32.MinValue, 12, 25, 33, 37, 48, 57, 92, Int32.MaxValue })]
        public void SortWithAuxVar(int[] data, int[] expected)
        {
            var sort = new Algorithms.Sorting.InsertionSort();
            var actual = sort.SortWithAux(data);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 25, 57, 48, Int32.MaxValue, Int32.MinValue, 37, 12, 92, 33 }, new int[] { Int32.MinValue, 12, 25, 33, 37, 48, 57, 92, Int32.MaxValue })]
        public void ThirdTry(int[] data, int[] expected)
        {
            var sort = new Algorithms.Sorting.InsertionSort();
            var actual = sort.ThirdTry(data);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 25, 57, 48, Int32.MaxValue, Int32.MinValue, 37, 12, 92, 33 })]
        public void CompareMethods(int[] data)
        {
            var sort = new Algorithms.Sorting.InsertionSort();
            var xor = sort.SortWithXOR(data);
            var aux = sort.SortWithAux(data);

            CollectionAssert.AreEqual(xor, aux);
        }
    }
}
