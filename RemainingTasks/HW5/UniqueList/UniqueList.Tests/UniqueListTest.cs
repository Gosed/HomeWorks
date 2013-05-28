using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueList.Tests
{
    [TestClass]
    public class UniqueListTest
    {
        [TestMethod]
        public void ListIsEmptyTest()
        {
            UniqueList list = new UniqueList();
            Assert.IsTrue(list.ListIsEmpty());
        }

        [TestMethod]
        public void AddToListTest()
        {
            UniqueList list = new UniqueList();
            list.AddToList(4);
            Assert.IsFalse(list.ListIsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DeletFromListTest1()
        {
            UniqueList list = new UniqueList();
            list.DeleteFromList(5);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DeletFromListTest2()
        {
            UniqueList list = new UniqueList();
            list.AddToList(4);
            list.DeleteFromList(4);
            Assert.IsTrue(list.ListIsEmpty());
            list.AddToList(4);
            list.DeleteFromList(5);
        }

        [TestMethod]
        public void ElementExistTest()
        {
            UniqueList list = new UniqueList();
            list.AddToList(4);
            Assert.IsTrue(list.ElementExist(4));
            Assert.IsFalse(list.ElementExist(5));
        }

        [TestMethod]
        public void SizeOfListTest()
        {
            UniqueList list = new UniqueList();
            list.AddToList(1);
            list.AddToList(2);
            list.AddToList(3);
            list.AddToList(3);
            Assert.AreEqual(3, list.SizeOfList());
        }

        [TestMethod]
        public void DataFromPosTest()
        {
            UniqueList list = new UniqueList();
            list.AddToList(1);
            list.AddToList(2);
            list.AddToList(3);
            list.AddToList(5);
            list.AddToList(4);
            Assert.AreEqual(3, list.DataFromPos(3));
            Assert.AreEqual(4, list.DataFromPos(5));
        }
    }
}
