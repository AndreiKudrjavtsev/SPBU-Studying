using System;
using StackCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayStack.Test
{
    [TestClass]
    public class ArrayStackTests
    {
        ArrayStack<int> stack = new ArrayStack<int>(10);

        [TestMethod]
        public void PushTest()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(10);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void PopTest()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Peek());
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PopFromEmptyStackTest()
        {
            stack.Pop();
        }

        [TestMethod]
        public void PopAndPushTest()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Peek());
            stack.Pop();
            Assert.AreEqual(2, stack.Peek());
            stack.Pop();
            Assert.AreEqual(1, stack.Peek());
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }
    }
}
