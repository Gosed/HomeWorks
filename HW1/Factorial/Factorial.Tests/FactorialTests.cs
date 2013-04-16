using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace Factorial.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FactorialTest()
        {
            Assert.AreEqual(Program.Factorial(6), 720);
        }
    }
}
