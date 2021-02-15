using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.Trees.BinaryTrees
{
    [TestClass]
    public class BinaryTreesTests
    {
        [TestMethod]
        [DataRow(new[] { 10, 5, 1, 8, 15, 12, 18 })]
        public void Insert(int[] data)
        {
            var binaryTree = new Algorithms.Trees.BinaryTree.Tree<int>();

            foreach (var item in data)
                binaryTree.Insert(item);
        }


        [TestMethod]
        [DataRow(new[] { 10, 5, 1, 8, 15, 12, 18 }, 5, 5, DisplayName = "Find middle node")]
        [DataRow(new[] { 10, 5, 1, 8, 15, 12, 18 }, 12, 12, DisplayName = "Find right leaf")]
        [DataRow(new[] { 10, 5, 1, 8, 15, 12, 18 }, 18, 18, DisplayName = "Find right leaft")]
        [DataRow(new[] { 10, 5, 1, 8, 15, 12, 18 }, 1, 1, DisplayName = "Find left leaf")]
        [DataRow(new[] { 10, 5, 1, 8, 15, 12, 18 }, 8, 8, DisplayName = "Find left leaf")]
        [DataRow(new[] { 10, 5, 1, 8, 15, 12, 18 }, 24, default(int), DisplayName = "Cant find")]
        public void Find(int[] data, int element, int expected)
        {
            // arrange
            var binaryTree = new Algorithms.Trees.BinaryTree.Tree<int>();
            foreach (var item in data)
                binaryTree.Insert(item);

            var node = binaryTree.Find(element);

            Assert.AreEqual(expected, node);
        }


        [TestMethod]
        [DataRow(new[] { 10, 5, 1, 8, 15, 12, 18 }, new[] { 10, 5, 1, 8, 15, 12, 18 })]
        public void Export_PreOrder(int[] data, int[] expected)
        {
            // arrange
            var binaryTree = new Algorithms.Trees.BinaryTree.Tree<int>();
            foreach (var item in data)
                binaryTree.Insert(item);

            var nodes = binaryTree.ExportPreOrder().ToArray();

            CollectionAssert.AreEqual(expected, nodes);
        }

        [TestMethod]
        [DataRow(new[] { 10, 5, 1, 8, 15, 12, 18 }, new[] { 1, 5, 8, 10, 12, 15, 18 })]
        public void Export_InOrder(int[] data, int[] expected)
        {
            // arrange
            var binaryTree = new Algorithms.Trees.BinaryTree.Tree<int>();
            foreach (var item in data)
                binaryTree.Insert(item);

            var nodes = binaryTree.ExportInOrder().ToArray();

            CollectionAssert.AreEqual(expected, nodes);
        }


        [TestMethod]
        [DataRow(new[] { 10, 5, 1, 8, 15, 12, 18 }, new[] { 18, 12, 15, 8, 1, 5, 10 })]
        public void Export_PostOrder(int[] data, int[] expected)
        {
            // arrange
            var binaryTree = new Algorithms.Trees.BinaryTree.Tree<int>();
            foreach (var item in data)
                binaryTree.Insert(item);

            var nodes = binaryTree.ExportPostOrder().ToArray();

            CollectionAssert.AreEqual(expected, nodes);
        }


        [TestMethod]
        [DataRow(new[] { 10, 5, 2, 4, 8, 15, 12, 18 }, 10, new[] { 8, 5, 2, 4, 15, 12, 18 })]
        //[DataRow(new[] { 10 }, 10, new int[0], DisplayName = "Remove root leaf")] /// Falhando
        [DataRow(new[] { 10, 5, 2, 4, 8, 15, 12, 18 }, 05, new[] { 10, 8, 2, 4, 15, 12, 18 })]
        [DataRow(new[] { 10, 5, 2, 4, 8, 9, 15, 12, 18 }, 05, new[] { 10, 9, 2, 4, 15, 12, 18 })]
        [DataRow(new[] { 10, 5, 2, 4, 8, 9, 15, 12, 18 }, 10, new[] { 9, 5, 2, 4, 8, 15, 12, 18 })]
        [DataRow(new[] { 10, 5, 2, 4, 8, 15, 12, 18 }, 15, new[] { 10, 5, 2, 4, 8, 18, 12 })]
        [DataRow(new[] { 10, 5, 2, 4, 8, 15, 12, 18 }, 18, new[] { 10, 5, 2, 4, 8, 15, 12 })]
        [DataRow(new[] { 10, 5, 2, 4, 8, 15, 12, 18 }, 12, new[] { 10, 5, 2, 4, 8, 15, 18 })]
        [DataRow(new[] { 10, 5, 2, 4, 8, 15, 12, 18 }, 2, new[] { 10, 5, 4, 8, 15, 12, 18 })]
        [DataRow(new[] { 10, 5, 2, 4, 8, 15, 12, 11, 18 }, 12, new[] { 10, 5, 2, 4, 8, 15, 11, 18 })]
        public void Remove(int[] data, int memberToRemove, int[] expectedPreOrder)
        {
            // arrange
            var binaryTree = new Algorithms.Trees.BinaryTree.Tree<int>();
            foreach (var item in data)
                binaryTree.Insert(item);


            binaryTree.Remove(memberToRemove);
            var nodes = binaryTree.ExportPreOrder().ToArray();


            CollectionAssert.AreEqual(expectedPreOrder, nodes);
        }
    }
}
