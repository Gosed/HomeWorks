using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Filter.Tests
{
    [TestClass]
    public class FTest
    {
        [TestMethod]
        public void Test()
        {
            List<int> list = new List<int>() {1, 2, 3};
            List<int> Result = Filter.FFunction(list, x => x == 2);
            Assert.AreEqual(Result[0], 2);
            Assert.AreEqual(Result.Count, 1);
        }
    }
}
