using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hash4
{
    class HashTable
    {
        private const int n = 100;
        private List[] list;

        /// <summary>
        /// Creating of a hash table
        /// </summary>
        public HashTable()
        {
            list = new List[n];
            for (int i = 0; i < n; ++i)
            {
                list[i] = new List();
            }

        }

        private HashInterface hash;

        /// <summary>
        /// Search in ht
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SearchInHT(int value)
        {
            int h = hash.Hash(value, n);
            return list[h].SearchInList(value);
        }

        /// <summary>
        /// Deleting in ht
        /// </summary>
        /// <param name="value"></param>
        public void Remove(int value)
        {
            int h = hash.Hash(value, n);
            ListElement pos = list[h].First();
            while ((pos.next != null) || (list[h].Retrieve(pos) != value))
            {
                int temp = list[h].Retrieve(pos);
                pos = list[h].Next(pos);
            }
            if (list[h].Retrieve(pos) == value)
            {
                list[h].DeleteFromList(pos);
            }
        }

        /// <summary>
        /// Adding to the ht
        /// </summary>
        /// <param name="value"></param>
        public void AddToHT(int value)
        {
            if (!SearchInHT(value))
            {
                int h = hash.Hash(value, n);
                ListElement pos = list[h].First();
                list[h].AddToList(value, pos);
            }
        }
    }
}
