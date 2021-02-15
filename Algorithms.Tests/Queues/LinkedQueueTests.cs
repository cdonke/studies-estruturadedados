using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Queues
{
    [TestClass]
    public class LinkedQueueTests
    {
        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 })]
        public void Push(int[] data)
        {
            var queue = new Algorithms.Queues.LinkedQueue<int>();

            foreach (var item in data)
                queue.Enqueue(item);

            Assert.AreEqual(queue.Tamanho, data.Length);
        }

        [TestMethod]
        [DataRow(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 })]
        public void Pop(int[] data)
        {
            var countData = 0;
            var queue = new Algorithms.Queues.LinkedQueue<int>();
            foreach (var item in data)
            {
                queue.Enqueue(item);
                countData++;
            }

            var maxSize = queue.Tamanho;
            List<int> returns = new List<int>();
            for (int i = 0; i < countData; i++)
                returns.Add(queue.Dequeue());

            Assert.AreEqual(maxSize, data.Length);
            Assert.AreEqual(0, queue.Tamanho);
            CollectionAssert.AreEqual(returns.ToArray(), data);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Pop_Empty()
        {
            var queue = new Algorithms.Queues.LinkedQueue<int>();
            queue.Dequeue();
        }
    }
}
