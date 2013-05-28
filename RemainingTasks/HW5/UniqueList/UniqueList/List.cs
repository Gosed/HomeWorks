using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniqueList
{
    public class List
    {
        /// <summary>
        /// List element
        /// </summary>
        public class ListElement
        {
            public int Data { get; set; }
            public ListElement Next { get; set; }
            public ListElement(int value)
            {
                this.Data = value;
            }
        }

        /// <summary>
        /// Head of the list
        /// </summary>
        public ListElement head = null;
        
        /// <summary>
        /// Method counts the size of list
        /// </summary>
        /// <returns>Size of the list</returns>
        public int SizeOfList()
        {
            if (ListIsEmpty())
                return 0;
            ListElement iterator = this.head;
            int size = 1;
            while (iterator.Next != null)
            {
                iterator = iterator.Next;
                size++;
            }
            return size;
        }

        /// <summary>
        /// Method returns element from his position
        /// </summary>
        /// <param name="pos">Position</param>
        /// <returns>Element on this position</returns>
        public int DataFromPos(int pos)
        {
            if (SizeOfList() < pos)
                throw new Exception("Position larger than size of the list");
            ListElement iterator = this.head;
            int size = 1;
            while (size != pos)
            {
                iterator = iterator.Next;
                size++;
            }
            return iterator.Data;
        }

        /// <summary>
        /// True if list is empty
        /// </summary>
        /// <returns></returns>
        public bool ListIsEmpty()
        {
            return (this.head == null);
        }

        /// <summary>
        /// Printing of a list
        /// </summary>
        public void Print()
        {
            ListElement iterator = this.head;
            while (iterator != null)
            {
                Console.WriteLine(iterator.Data);
                iterator = iterator.Next;
            }
        }
    }
}
