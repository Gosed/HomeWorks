using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace FibbonachiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FibbonachiTest()
        {
            Assert.AreEqual(Program.Fibbonachi(6), 8);
        }
    }
}
