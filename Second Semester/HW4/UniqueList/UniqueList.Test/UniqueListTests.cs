using System;
using UniqueList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueList.Test
{
    [TestClass]
    public class UniqueListTests
    {
        private UniqueList<int> list = new UniqueList<int>();

        [TestMethod]
        [ExpectedException(typeof(AddExistingException))]
        public void AddExistingValueTest()
        {
            list.InsertAsHead(1);
            list.InsertAsHead(1);
            Assert.AreEqual(1, list.ListSize());
        }

        [TestMethod]
        [ExpectedException(typeof(DeleteNotExistingException))]
        public void DeleteNotExistingValueTest()
        {
            list.InsertAsHead(1);
            list.DeleteByValue(2);
            Assert.AreEqual(1, list.ListSize());
        }
    }
}
