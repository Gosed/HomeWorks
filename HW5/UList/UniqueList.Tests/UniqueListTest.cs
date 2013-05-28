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
        [ExpectedException(typeof(System.Exception))]
        public void AddTest()
        {
            UList.UniqueList list = new UList.UniqueList();
            list.AddToList(6);
            list.AddToList(6);
            Assert.AreEqual(list.HeadValue(), 6);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DeleteTest()
        {
            UList.UniqueList list = new UList.UniqueList();
            list.DeleteFromList(6);
            list.AddToList(7);
            list.DeleteFromList(7);
            Assert.IsTrue(list.ListIsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void PrintTest()
        {
            UList.UniqueList list = new UList.UniqueList();
            list.PrintList();
        }
    }
}
