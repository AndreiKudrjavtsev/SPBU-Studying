using System;
using UniqueList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueList.Test
{
    [TestClass]
    public class UniqueListTests
    {
        private UniqueList<int> list;

        [TestMethod]
        [ExpectedException(typeof(AddExistingException))]
        public void AddExistingValueTest()
        {
            list = new UniqueList<int>();
            list.InsertAsHead(1);
            list.InsertAsHead(1);
            Assert.AreEqual(1, list.ListSize());
        }
    }
}
