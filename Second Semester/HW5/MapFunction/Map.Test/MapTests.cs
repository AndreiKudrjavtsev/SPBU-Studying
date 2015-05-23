using System;
using MapFunction;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MapTest
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void MapTestMehod()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            List<int> expectedList = new List<int> { 2, 4, 6 };
            List<int> newList = Map.MapFunc(list, x => x * 2);
            CollectionAssert.AreEqual(expectedList, newList);
        }
    }
}
