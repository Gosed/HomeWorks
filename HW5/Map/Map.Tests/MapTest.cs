using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Map.Tests
{
    [TestClass]
    public class MapTests
    {
        private List<int> list;
        private List<int> Result;

        [TestMethod]
        public void MTest()
        {
            Result = new List<int> {0, 4, 20};
            list = MapFunction.MFunction(new List<int> {0, 2, 10}, x => x * 2);
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(list[i], Result[i]);
            }
        }
    }
}
