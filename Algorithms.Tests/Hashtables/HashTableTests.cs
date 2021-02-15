using BenchmarkDotNet.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Hashtables
{
    [TestClass]
    public class HashTableTests
    {

        [TestMethod]
        public void Insertion()
        {
            // arrange
            var mapa = new Algorithms.Hashtables.HashTable<string>();

            // act 
            mapa.Put(7865, "Isidro");
            mapa.Put(7765, "Irmao do Isidro");
            mapa.Put(123, "Josineidson");
            mapa.Put(987, "Nilsonclecio");
            mapa.Put(9832, "Deosdedite");

            //assert 
            Assert.AreEqual(5, mapa.Count);
        }
        [TestMethod]
        public void Insertion_WithCollision()
        {
            // arrange
            var mapa = new Algorithms.Hashtables.HashTable<string>();

            // act 
            mapa.Put(7865, "Isidro");
            mapa.Put(7765, "Irmao do Isidro");
            mapa.Put(7965, "Primo do Isidro");

            //assert 
            Assert.AreEqual(3, mapa.Count);
        }


        [TestMethod]
        [DataRow(7865, 7865)]
        [DataRow(987, 987)]
        [DataRow(1, null)]
        [DataRow(7765, 7765)]
        [DataRow(7665, null)]
        public void Get(int key, object expected)
        {
            // arrange
            var mapa = new Algorithms.Hashtables.HashTable<string>();
            mapa.Put(7865, "Isidro");
            mapa.Put(7765, "Irmao do Isidro");
            mapa.Put(123, "Josineidson");
            mapa.Put(987, "Nilsonclecio");
            mapa.Put(9832, "Deosdedite");


            // act 
            var node = mapa.Get(key);

            //assert 
            Assert.AreEqual(node?.Key, expected);

        }

        [TestMethod]
        public void Update()
        {
            // arrange
            var oldValue = "Value 1";
            var newValue = "Value 2";
            var key = 7865;

            var mapa = new Algorithms.Hashtables.HashTable<string>();
            mapa.Put(key, oldValue);
            
            // act 
            mapa.Put(key, newValue);
            var node = mapa.Get(key);

            //assert 
            Assert.AreEqual(node.Key, key);
            Assert.AreEqual(node.Value, newValue);
        }

        [TestMethod]
        public void Update_WithCollision()
        {
            // arrange
            var oldValue = "Value 1";
            var newValue = "Value 2";
            var key = 7965;

            var mapa = new Algorithms.Hashtables.HashTable<string>();
            mapa.Put(7765, oldValue);
            mapa.Put(7865, oldValue);
            mapa.Put(key, oldValue);

            // act 
            mapa.Put(key, newValue);
            var node = mapa.Get(key);

            //assert 
            Assert.AreEqual(node.Key, key);
            Assert.AreEqual(node.Value, newValue);
        }

        [TestMethod]
        public void Update_WithCollision_MiddleElement()
        {
            // arrange
            var oldValue = "Value 1";
            var newValue = "Value 2";
            var key = 7965;

            var mapa = new Algorithms.Hashtables.HashTable<string>();
            mapa.Put(7765, oldValue);
            mapa.Put(key, oldValue);
            mapa.Put(7865, oldValue);

            // act 
            mapa.Put(key, newValue);
            var node = mapa.Get(key);

            //assert 
            Assert.AreEqual(node.Key, key);
            Assert.AreEqual(node.Value, newValue);
        }
    }
}
