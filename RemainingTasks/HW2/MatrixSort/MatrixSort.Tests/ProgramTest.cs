using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixSort.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void QMatrixSortTest()
        {
            int[,] array = new int[3, 5];
            array[0, 0] = 4; array[0, 1] = 9; array[0, 2] = 2; array[0, 3] = 3; array[0, 4] = 5; 
            array[1, 0] = 7; array[1, 1] = 8; array[1, 2] = 9; array[1, 3] = 0; array[1, 4] = 3;
            array[2, 0] = 4; array[2, 1] = 8; array[2, 2] = 6; array[2, 3] = 8; array[2, 4] = 8;
            Program.QMatrixSort(array, 0, 4, 3);
            Assert.AreEqual(2, array[0, 0]); Assert.AreEqual(3, array[0, 1]); Assert.AreEqual(4, array[0, 2]); Assert.AreEqual(5, array[0, 3]); Assert.AreEqual(9, array[0, 4]);
            Assert.AreEqual(9, array[1, 0]); Assert.AreEqual(0, array[1, 1]); Assert.AreEqual(7, array[1, 2]); Assert.AreEqual(3, array[1, 3]); Assert.AreEqual(8, array[1, 4]);
            Assert.AreEqual(6, array[2, 0]); Assert.AreEqual(8, array[2, 1]); Assert.AreEqual(4, array[2, 2]); Assert.AreEqual(8, array[2, 3]); Assert.AreEqual(8, array[2, 4]);
        }
    }
}
