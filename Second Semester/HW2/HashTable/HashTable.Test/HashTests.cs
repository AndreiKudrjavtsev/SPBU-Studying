using System;
using hashTable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hashTable.Test
{
    [TestClass]
    public class HashTests
    {
        private HashTable hash = new HashTable(31);

        [TestMethod]
        public void AddElementTest()
        {
            hash.AddToHashTable("asdas");
            Assert.IsTrue(hash.IsContains("asdas"));
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            hash.AddToHashTable("abc");
            Assert.IsTrue(hash.IsContains("abc"));
            hash.DeleteFromHashTable("abc");
            Assert.IsFalse(hash.IsContains("abc"));
        }

        [TestMethod]
        public void IsContainsTest()
        {
            hash.AddToHashTable("qq");
            Assert.IsTrue(hash.IsContains("qq"));
            Assert.IsFalse(hash.IsContains("qqqq"));
        }
    }
}
