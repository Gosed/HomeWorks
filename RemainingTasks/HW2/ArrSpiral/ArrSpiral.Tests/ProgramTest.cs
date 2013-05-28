using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrSpiral.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array = new int[3, 3];
            int[] resArray = new int[9];
            array[0, 0] = 1;
            array[0, 1] = 2;
            array[0, 2] = 3;
            array[1, 0] = 4;
            array[1, 1] = 5;
            array[1, 2] = 6;
            array[2, 0] = 7;
            array[2, 1] = 8;
            array[2, 2] = 9;
            Program.SpiralArray(array, 3, resArray);
            Assert.AreEqual(5, resArray[0]);
            Assert.AreEqual(6, resArray[1]);
            Assert.AreEqual(9, resArray[2]);
            Assert.AreEqual(8, resArray[3]);
            Assert.AreEqual(7, resArray[4]);
            Assert.AreEqual(4, resArray[5]);
            Assert.AreEqual(1, resArray[6]);
            Assert.AreEqual(2, resArray[7]);
            Assert.AreEqual(3, resArray[8]);
        }
    }
}
