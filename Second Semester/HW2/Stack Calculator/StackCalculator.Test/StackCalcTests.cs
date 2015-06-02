using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackCalculator.Test
{
    [TestClass]
    public class StackCalcTests
    {
        private ArrayStack<int> arrayStack = new ArrayStack<int>(1);
        private ListStack<int> listStack = new ListStack<int>();
        private StackCalculator calculator = new StackCalculator();

        [TestMethod]
        public void ListStackTest()
        {
            Assert.AreEqual(calculator.StackCalc(listStack, "10 5 +"), 15);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "10 5 -"), 5);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "10 5 /"), 2);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "10 5 *"), 50);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "10 5 / 3 3 + +"), 8);
        }

        [TestMethod]
        public void ArrayStackTest()
        {
            Assert.AreEqual(calculator.StackCalc(listStack, "10 5 +"), 15);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "10 5 -"), 5);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "10 5 /"), 2);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "10 5 *"), 50);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "10 5 / 3 3 + +"), 8);
        }
    }
}
