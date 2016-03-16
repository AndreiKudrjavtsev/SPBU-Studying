using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BST;

namespace BSTTest
{
    [TestClass]
    public class BinarySearchTreeTest
    {
        private BinarySearchTree<int> tree;

        [TestInitialize]
        public void Initialize()
        {
            tree = new BinarySearchTree<int>();
        }

        [TestMethod]
        public void TestForEmptiness()
        {
            Assert.IsTrue(tree.IsEmpty());
        }

        [TestMethod]
        public void InsertionTest()
        {
            tree.Insert(1);
            tree.Insert(2);
            Assert.IsFalse(tree.IsEmpty());
        }

        [TestMethod]
        public void DeletingTest()
        {
            tree.Insert(1);
            tree.Insert(2);
            tree.Delete(2);
            Assert.IsFalse(tree.IsFound(2));
        }
       
        [TestMethod]
        [ExpectedException(typeof(InsertExistingElementException))]
        public void InsertExceptionTest()
        {
            tree.Insert(1);
            tree.Insert(1);
        }

        [TestMethod]
        public void ForeachTest()
        {
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);

            int res = 1;
            foreach (var val in tree)
                res *= val;

            Assert.IsTrue(res == 24);
        }


    }
}
