using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.Stacks
{
    [TestClass]
    public class LinkedStackTests
    {
        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 })]
        public void Push(int[] data)
        {
            var stack = new Algorithms.Stacks.LinkedStack<int>();
            foreach (var item in data)
                stack.Push(item);

            Assert.AreEqual(stack.Size, data.Length);
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30 })]
        public void Pop(int[] data)
        {
            var stack = new Algorithms.Stacks.LinkedStack<int>();
            foreach (var item in data)
                stack.Push(item);

            Assert.AreEqual(stack.Size, data.Length);

            var results = new int[data.Length];
            for (int i = data.Length - 1; i >= 0; i--)
                results[i] = stack.Pop();

            CollectionAssert.AreEqual(results, data);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Pop_Empty()
        {
            var stack = new Algorithms.Stacks.LinkedStack<int>();
            stack.Pop();
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30 })]
        public void Pop_N(int[] data)
        {
            var stack = new Algorithms.Stacks.LinkedStack<int>();
            foreach (var item in data)
                stack.Push(item);

            Assert.AreEqual(stack.Size, data.Length);

            var results = stack.Pop(data.Length).Reverse().ToArray();

            CollectionAssert.AreEqual(results, data);
        }
    }
}
