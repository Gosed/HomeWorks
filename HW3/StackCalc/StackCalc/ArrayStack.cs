using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalc
{
    public class ArrayStack : StackInterface
    {
        /// <summary>
        /// Length of a stack
        /// </summary>
        private int lengthStack;

        /// <summary>
        /// Array
        /// </summary>
        private int[] StackArr;

        /// <summary>
        /// Creating of stack on array
        /// </summary>
        public ArrayStack()
        {
            lengthStack = 0;
            StackArr = new int[100];
        }

        /// <summary>
        /// True if array is full
        /// </summary>
        /// <returns></returns>
        private bool ArrayFull()
        {
            return (StackArr.Length - 2 > lengthStack);
        }        

        /// <summary>
        /// Taking an element from stack
        /// </summary>
        public int Pop()
        {
            if (IsEmpty())
                return 0;
            int tmp = StackArr[lengthStack - 1];
            lengthStack--;
            StackArr[lengthStack] = 0;
            return tmp;
        }

        /// <summary>
        /// Adding element to a stack
        /// </summary>
        public void Push(int num)
        {
            if (!(ArrayFull()))
            {
                int[] tmp = new int[StackArr.Length * 2];
                for (int i = 0; i < StackArr.Length; ++i)
                {
                    tmp[i] = StackArr[i];
                }
                StackArr = tmp;
            }
            StackArr[lengthStack] = num;
            ++lengthStack;
        }

        /// <summary>
        /// If stack is empty
        /// </summary>
        /// <returns>True if empty</returns>
        private bool IsEmpty()
        {
            return (lengthStack == 0);
        }
    }
}
