using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW2_Stack;

namespace Stack.Test
{
    [TestClass]
    public class StackTest
    {
        private Stack<int> stack;

        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack<int>();
        }

        [TestMethod]
        public void PushTest()
        {
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void PopTest()
        {
            stack.Push(1);
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void PeekTest()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Peek());
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void PushAndPopTest()
        {
            stack.Push(1);
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
            stack.Pop(); 
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }
    }
}
