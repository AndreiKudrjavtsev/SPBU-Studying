using System;
using System.Collections.Generic;
using ParseTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParseTree.Test
{
    [TestClass]
    public class ParseTreeTests
    {
        private Tree tree;

        [TestMethod]
        public void CalculateTreeTest1()
        {
            string expr = "(+ 1 1)";
            tree = CreateTree.TreeBuilder(expr);
            Assert.AreEqual(2, tree.CalculateTree());
        }

        [TestMethod]
        public void CalculateTreeTest2()
        {
            string expr = "(* (+ 1 1) 2)";
            tree = CreateTree.TreeBuilder(expr);
            Assert.AreEqual(4, tree.CalculateTree());
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CalculateTreeTest3()
        {
            string expr = "(/ (+ 1 1) 0)";
            tree = CreateTree.TreeBuilder(expr);
            tree.CalculateTree();
        }
    }
}
