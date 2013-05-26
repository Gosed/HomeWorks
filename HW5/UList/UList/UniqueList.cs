using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UList
{
    public class UniqueList
    {
        /// <summary>
        /// Building of a list
        /// </summary>
        private class ListElement
        {
            public int Data { get; set; }
            public ListElement Next { get; set; }
            public ListElement(int value)
            {
                this.Data = value;
                this.Next = null;
            }
        }

        /// <summary>
        /// Head of a list
        /// </summary>
        private ListElement head = null;

        /// <summary>
        /// Value of the head
        /// </summary>
        /// <returns>Head value</returns>
        public int HeadValue()
        {
            return this.head.Data;
        }

        /// <summary>
        /// True if list is empty
        /// </summary>
        /// <returns>If list is empty</returns>
        public bool ListIsEmpty()
        {
            return (this.head == null);
        }

        /// <summary>
        /// Adding value to a list
        /// </summary>
        /// <param name="value">Value to add</param>
        public void AddToList(int value)
        {
            ListElement tmp = new ListElement(value);
            if (this.head == null)
            {
                this.head = tmp;
                return;
            }
            ListElement iterator = this.head;
            while (iterator != null)
            {
                if (iterator.Data == value)
                    throw new Exception("Exists");
                if (iterator.Next == null)
                    break;
                iterator = iterator.Next;
            }
            iterator.Next = tmp;
        }

        /// <summary>
        /// Deleting a value from a list
        /// </summary>
        /// <param name="number"></param>
        public void DeleteFromList(int number)
        {
            if (head == null)
            {
                throw new Exception("List is empty");
            }
            ListElement el = this.head;
            if (el.Data == number)
            {
                head = el.Next;
                return;
            }
            while (el.Next != null)
            {

                if (el.Next.Data == number)
                {
                    el.Next = el.Next.Next;
                    return;
                }
                el = el.Next;
            }
            throw new Exception("No such element");
        }

        /// <summary>
        /// Printing of a list
        /// </summary>
        public void PrintList()
        {
            ListElement iterator = this.head;
            if (iterator == null)
                throw new Exception("List is empty");
            while (iterator != null)
            {
                Console.WriteLine(iterator.Data);
                iterator = iterator.Next;
            }
        }
        

    }
}
