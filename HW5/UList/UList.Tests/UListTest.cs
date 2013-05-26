using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UList.Tests
{
    class UListTest
    {
        [TestMethod]
        public void AddTest()
        {
            UniqueList list = new UniqueList();
            list.AddToList(5);
            Assert.AreEqual(list.HeadValue(), 5);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DeleteTest()
        {
            UniqueList list = new UniqueList();
            list.DeleteFromList(5);
        }

        [TestMethod]
        public void DeleteTest()
        {
            UniqueList list = new UniqueList();
            list.AddToList(7);
            list.DeleteFromList(7);
            Assert.IsTrue(list.ListIsEmpty());
        }

        [TestMethod]
        public void PrintTest()
        {
            UniqueList list = new UniqueList();
            list.PrintList();
        }
    }
}
