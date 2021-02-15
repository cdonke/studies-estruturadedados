using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Stacks
{
    [TestClass]
    public class StackWithArrayTests
    {
        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 })]
        public void Push(int[] data)
        {
            var stack = new Algorithms.Stacks.StackWithArrays<int>();
            foreach (var item in data)
                stack.Push(item);

            Assert.AreEqual(stack.Size, data.Length);
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40 }, 3)]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Push_Oversized(int[] data, int size)
        {
            var stack = new Algorithms.Stacks.StackWithArrays<int>(size);
            foreach (var item in data)
                stack.Push(item);
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30 })]
        public void Pop(int[] data)
        {
            var stack = new Algorithms.Stacks.StackWithArrays<int>();
            foreach (var item in data)
                stack.Push(item);

            Assert.AreEqual(stack.Size, data.Length);

            var reversedResults = new int[data.Length ];
            for (int i = data.Length - 1; i >= 0; i--)
                reversedResults[i] = stack.Pop();

            CollectionAssert.AreEqual(reversedResults, data);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Pop_Empty()
        {
            var stack = new Algorithms.Stacks.StackWithArrays<int>();
            stack.Pop();
        }
    }
}
