using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickSort.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void QuickSortTest()
        {
            int[] array = new  int[5];
            array[0] = 87;
            array[1] = 1;
            array[2] = 1023;
            array[3] = 111;
            array[4] = 5;
            Program.QSort(array, 0, 4);
            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(5, array[1]);
            Assert.AreEqual(87, array[2]);
            Assert.AreEqual(111, array[3]);
            Assert.AreEqual(1023, array[4]);
        }
    }
}
