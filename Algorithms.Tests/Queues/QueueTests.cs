using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Queues
{
    [TestClass]
    public class QueueTests
    {

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 })]
        public void Push(int[] data)
        {
            var queue = new Algorithms.Queues.Queue();

            foreach (var item in data)
                queue.Enqueue(item);
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 })]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Push_Oversized(int[] data)
        {
            var queue = new Algorithms.Queues.Queue();

            foreach (var item in data)
                queue.Enqueue(item);
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30 })]
        public void Pop(int[] data)
        {
            var countData = 0;
            var queue = new Algorithms.Queues.Queue();
            foreach (var item in data)
            {
                queue.Enqueue(item);
                countData++;
            }

            List<int> returns = new List<int>();
            for (int i = 0; i < countData; i++)
                returns.Add(queue.Dequeue());

            CollectionAssert.AreEqual(returns.ToArray(), data);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Pop_Empty()
        {
            var queue = new Algorithms.Queues.Queue();
            int data = queue.Dequeue();
        }
    }
}
