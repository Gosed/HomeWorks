using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class StackClass
    {
        /// <summary>
        /// Building of a stack
        /// </summary>
        private class StackElement
        {
            public int Data { get; set; }
            public StackElement Next { get; set; }
            public StackElement(int value)
            {
                this.Data = value;
                this.Next = null;
            }
        }
        
        /// <summary>
        /// Head of a stack
        /// </summary>
        private StackElement head = null;

        /// <summary>
        /// Adding element to a stack
        /// </summary>
        public void Push(int number)
        {
            StackElement tmp = new StackElement(number);
            tmp.Next = this.head;
            this.head = tmp;
        }

        /// <summary>
        /// Taking an element from stack
        /// </summary>
        public void Pop()
        {
            StackElement iterator = this.head;
            if (iterator == null)
            {
                throw new Exception("Stack is empty");
            }
            this.head = iterator.Next;
            Console.WriteLine(iterator.Data);
        }
        
        /// <summary>
        /// Printing a stack
        /// </summary>
        public void Print()
        {
            StackElement iterator = this.head;
            if (iterator == null)
                Console.Write("Stack is empty");
            while (iterator != null)
            {
                Console.Write(iterator.Data);
                iterator = iterator.Next;
            }
        }

        /// <summary>
        /// If stack is empty
        /// </summary>
        /// <returns>True if empty</returns>
        public bool IsEmpty()
        {
            return (this.head == null);
        }
    }
}
