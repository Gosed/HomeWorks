using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class FoldTest
    {
        [TestMethod]
        public void FoldTests()
        {
            Assert.AreEqual(Fold.FoldClass.FoldFunct(new List<int>() {1, 2, 3}, 1, (acc, elem) => acc * elem), 6);
        }
    }
}
