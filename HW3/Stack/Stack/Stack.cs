using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Stack
    {
        /// <summary>
        /// Class which builds the list
        /// </summary>
        private class StackElement
        {
            public int Data { get; set; }

            public StackElement Next { get; set; }

            public StackElement(int value)
            {
                this.Data = value;
            }
        }

        /// <summary>
        /// Head of the list
        /// </summary>
        private StackElement head = null;

        /// <summary>
        /// Adds value to the list
        /// </summary>
        /// <param name="value">Value to add</param>
        public void push(int value)
        {
            StackElement tmp = new StackElement(value);
            if (this.head == null)
            {
                this.head = tmp;
                return;
            }
            StackElement iterator = this.head;
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
            StackElement iterator = this.head;
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
        public int Pop()
        {
            int result = 0;
            if (this.head == null)
                throw new Exception("Empty list");
            StackElement iterator = this.head;
            while (iterator.Next != null)
            {
                iterator = iterator.Next;
            }
            if (iterator.Next == null)
                result = iterator;
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
