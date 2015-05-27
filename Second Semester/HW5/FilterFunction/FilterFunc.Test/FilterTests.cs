using System;
using System.Collections.Generic;
using FilterFunction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilterFunction.Test
{
    [TestClass]
    public class FilterTests
    {
        [TestMethod]
        public void FilterTest()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            List<int> expectedList = new List<int> { 2 };
            List<int> newList = Filter.FilterFunction(list, (int x) => x % 2 == 0);
            CollectionAssert.AreEqual(expectedList, newList);
        }
    }
}
