using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace List.Tests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void AddTest()
        {
            PointerList list = new PointerList();
            list.Add(7);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DeleteTest()
        {
            PointerList list = new PointerList();
            list.Delete(56);
            list.Add(4);
            list.Delete(4);
            Assert.IsTrue(list.IsEmpty());
            list.Add(4);
            list.Delete(48);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void PrintTest()
        {
            PointerList list = new PointerList();
            list.Print();
        }
    }
}
