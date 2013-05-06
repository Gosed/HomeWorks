using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List
{
    public class PointerList
    {
        /// <summary>
        /// Class which builds the list
        /// </summary>
        private class ListElement
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
        private ListElement head = null;

        /// <summary>
        /// Adds value to the list
        /// </summary>
        /// <param name="value">Value to add</param>
        public void Add(int value)
        {
            ListElement tmp = new ListElement(value);
            if (this.head == null)
            {
                this.head = tmp;
                return;
            }
            ListElement iterator = this.head;
            while (iterator.Next != null)
            {
                iterator = iterator.Next;
            }
            iterator.Next = tmp;
        }

        /// <summary>
        /// Print the List
        /// </summary>
        public void Print()
        {
            ListElement iterator = this.head;
            if (iterator == null)
                throw new Exception("Empty List");
            while (iterator != null)
            {
                Console.WriteLine(iterator.Data);
                iterator = iterator.Next;
            }
        }

        /// <summary>
        /// Delete value from the list
        /// </summary>
        /// <param name="value">Number to delete</param>
        public void Delete(int value)
        {
            if (this.head == null)
                throw new Exception("Empty list");
            if (this.head.Data == value)
            {
                this.head = this.head.Next;
                return;
            }
            ListElement iterator = this.head;
            while ((iterator.Next != null) && (iterator.Next.Data != value))
            {
                iterator = iterator.Next;
            }
            if (iterator.Next == null)
                throw new Exception("No such element");
            iterator.Next = iterator.Next.Next;
        }

        /// <summary>
        /// If List is empty
        /// </summary>
        /// <returns>True if empty</returns>
        public bool IsEmpty()
        {
            return (this.head == null);
        }
    }
}
