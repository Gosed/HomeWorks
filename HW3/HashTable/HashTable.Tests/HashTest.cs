using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;

namespace HashTable.Tests
{
    [TestClass]
    class HashTest
    {
        /// <summary>
        /// Search in HT test
        /// </summary>
        [TestMethod]
        public void SearchTest()
        {
            HashTable ht = new HashTable(35);
            ht.AddToHashTable("LOLOLO");
            Assert.IsTrue(ht.Search("LOLOLO"));
        } 

        /// <summary>
        /// Adding to HT test
        /// </summary>
        [TestMethod]
        public void AddTest()
        {
            HashTable ht = new HashTable(35);
            ht.AddToHashTable("COME ON!");
            Assert.IsTrue(ht.Search("COME ON!"));
        }

        /// <summary>
        /// Deleting from HT test
        /// </summary>
        [TestMethod]
        public void DeleteTest()
        {
            HashTable ht = new HashTable(35);
            ht.AddToHashTable("GUITAR");
            ht.DeleteFromHashTable("GUITAR");
            Assert.IsFalse(ht.Search("GUITAR"));
        }

        
    }
}
