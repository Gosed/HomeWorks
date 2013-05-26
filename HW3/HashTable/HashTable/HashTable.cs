using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable
{
    public class HashTable
    {
        /// <summary>
        /// Size of the hashtable
        /// </summary>
        private int size;

        /// <summary>
        /// Array of lists
        /// </summary>
        private List[] data;

        public HashTable(int amount)
        {
            this.size = amount;
            data = new List[amount];
            for (int tmp = 0; tmp < amount; ++tmp)
            {
                data[tmp] = new List();
            }
        }

        /// <summary>
        /// Hash function
        /// </summary>
        public int HashFunction(string str, int max)
        {
            int result = 0;
            int tmp = 0;
            while (tmp < str.Length)
            {
                result = result + str[tmp];
                ++tmp;
            }
            return result % max;
        }

        /// <summary>
        /// Adding word to the hash table
        /// </summary>
        public void AddToHashTable(string word)
        {
            int index = HashFunction(word, this.size);
            if (this.data[index].Exist(word) == -1)
            {
                this.data[index].Add(word, 1);
            }
            else
            {
                ++this.data[index].Position(this.data[index].Exist(word)).Num;
            }
        }

        /// <summary>
        /// Printing of the hashtable
        /// </summary>
        public void PrintHashTable()
        {
            for (int tmp = 0; tmp < this.size; ++tmp)
                this.data[tmp].Print();
        }

        /// <summary>
        /// Deliting of an element from hash table
        /// </summary>
        public void DeleteFromHashTable(string HElement)
        {
            int index = HashFunction(HElement, this.size);
            if (this.data[index].Exist(HElement) >= 0)
            {
                --this.data[index].Position(this.data[index].Exist(HElement)).Num;
                if (this.data[index].Position(this.data[index].Exist(HElement)).Num == 0)
                    this.data[index].Delete(HElement);
            }
        }

        /// <summary>
        /// Finding a word in hash table
        /// </summary>
        public bool FindInHashTable(string word)
        {
            int index = HashFunction(word, this.size);
            return (this.data[index].Exist(word) != -1);
        }
    }
}
