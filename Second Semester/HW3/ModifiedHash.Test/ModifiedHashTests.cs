using System;
using NewHash;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModifiedHashTests
{
    [TestClass]
    public class ModifiedHashTests
    {
        private static Func<int, int> hashFunc = (int value) => { return value % 10; };
        private ModifiedHash<int> hash = new ModifiedHash<int>(10, hashFunc);

        [TestMethod]
        public void AddElementTest()
        {
            hash.AddToHashTable(10);
            Assert.IsTrue(hash.IsContains(10));
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            hash.AddToHashTable(10);
            Assert.IsTrue(hash.IsContains(10));
            hash.DeleteFromHashTable(10);
            Assert.IsFalse(hash.IsContains(10));
        }

        [TestMethod]
        public void DeleteElementTest2()
        {
            hash.AddToHashTable(1);
            hash.AddToHashTable(2);
            hash.AddToHashTable(3);
            hash.DeleteFromHashTable(2);
            Assert.IsFalse(hash.IsContains(2));
        }

        [TestMethod]
        public void ChangeFuncTest()
        {
            hash.AddToHashTable(11);
            Assert.IsTrue(hash.IsContains(11));
            Func<int, int> hashFunc = (int val) => { return val % 7; };
            hash.ChangeHashFunc(hashFunc);
            Assert.IsTrue(hash.IsContains(11));
        }
    }
}
