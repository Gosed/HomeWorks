using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SetGeneric.Tests
{
    [TestClass]
    public class SetTest
    {
        private Set<int> set1;
        private Set<int> set2;

        [TestInitialize]
        public void Initialize()
        {
            set1 = new Set<int>();
            set2 = new Set<int>();
        }
        
        [TestMethod]
        public void TestUnion()
        {
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set2.Add(4);
            set2.Add(1);
            set2.Add(2);
            var set = new Set<int>();
            set = set1.Union(set2);
            var arr = new int[4];
            int i = 0;
            foreach (int x in set)
            {
                arr[i] = x;
                ++i;
            }
            Assert.AreEqual(4, arr[0]);
            Assert.AreEqual(1, arr[1]);
            Assert.AreEqual(2, arr[2]);
            Assert.AreEqual(3, arr[3]);
        }        

        [TestMethod]
        public void TestCrossing()
        {
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set2.Add(4);
            set2.Add(1);
            set2.Add(2);
            var set = new Set<int>();
            set = set1.Crossing(set2);
            var arr = new int[2];
            int i = 0;
            foreach (int x in set)
            {
                arr[i] = x;
                ++i;
            }
            Assert.AreEqual(1, arr[0]);
            Assert.AreEqual(2, arr[1]);
        }
    }
}
