using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericClasses.Test
{
    [TestClass]
    public class ListTests
    {
        private GenericList<int> list = new GenericList<int>();

        [TestMethod]
        public void InsertTest()
        {
            list.InsertAsHead(1);
            Assert.IsTrue(list.IsContains(1));
        }

        [TestMethod]
        public void DeleteTest()
        {
            list.InsertAsHead(1);
            list.DeleteByValue(1);
            Assert.IsFalse(list.IsContains(1));
        }

        [TestMethod]
        public void ContainmentTest()
        {
            list.InsertAsHead(1);
            Assert.IsTrue(list.IsContains(1));
            Assert.IsFalse(list.IsContains(10));
        }

        [TestMethod]
        public void SizeTest()
        {
            for (int i = 0; i < 5; i++)
                list.InsertAsHead(1);
            Assert.AreEqual(list.ListSize(), 5);
        }

        [TestMethod]
        public void NumeratorTest()
        {
            list.InsertAsHead(1);
            list.InsertAsHead(2);
            list.InsertAsHead(3);
            list.InsertAsHead(4);
            int count = 0;
            foreach (int val in list)
            {
                count++;
            }
            Assert.AreEqual(4, count);
        }
    }
}
