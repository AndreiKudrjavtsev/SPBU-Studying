using System;
using GenericClasses;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericClasses.Test
{
    [TestClass]
    public class StackTests
    {
        private GenericStack<int> stack = new GenericStack<int>();

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

        [TestMethod]
        public void NumeratorTest()
        {
            stack.Push(1);
            stack.Push(2); 
            stack.Push(3);
            stack.Push(4);
            int count = 0;
            foreach (int val in stack)
            {
                count++;
            }
            Assert.AreEqual(4, count);
        }
    }
}
