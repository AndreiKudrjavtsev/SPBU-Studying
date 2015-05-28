using System;
using System.Collections.Generic;
using FoldFunction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoldFunction.Test
{
    [TestClass]
    public class FoldTests
    {
        [TestMethod]
        public void FoldTest()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            int newValue = Fold.FoldFunction(list, 1, (acc, elem) => acc * elem);
            int expectedValue = 6;
            Assert.AreEqual(newValue, expectedValue);
        }
    }
}
