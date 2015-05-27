using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericSet.Test
{
    [TestClass]
    public class SetTests
    {
        private Set<int> set = new Set<int>();

        [TestMethod]
        public void EmptinessTest()
        {
            Assert.IsTrue(set.IsEmpty());
            set.AddElement(1);
            Assert.IsFalse(set.IsEmpty());
        }

        [TestMethod]
        public void ContainsTest()
        {
            set.AddElement(1);
            Assert.IsTrue(set.IsContains(1));
            Assert.IsFalse(set.IsContains(10));
        }

        [TestMethod]
        public void AddElementTest()
        {
            set.AddElement(1);
            Assert.IsTrue(set.IsContains(1));
            Assert.IsFalse(set.IsEmpty());
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            set.AddElement(1);
            Assert.IsTrue(set.IsContains(1));
            set.DeleteElement(1);
            Assert.IsFalse(set.IsContains(1));
        }

        [TestMethod]
        public void UnionTest()
        {
            Set<int> newSet = new Set<int>();
            set.AddElement(1);
            set.AddElement(3);
            newSet.AddElement(0);
            newSet = set.SetUnion(newSet);
            List<int> expectedList = new List<int> { 1, 3, 0 };
            CollectionAssert.AreEqual(newSet.elementSet, expectedList);
        }

        [TestMethod]
        public void IntersectionTest()
        {
            Set<int> newSet = new Set<int>();
            set.AddElement(1);
            set.AddElement(2);
            newSet.AddElement(0);
            newSet.AddElement(1);
            newSet = set.SetIntersection(newSet);
            List<int> expectedList = new List<int> { 1 };
            CollectionAssert.AreEqual(newSet.elementSet, expectedList);
        }
    }
}
