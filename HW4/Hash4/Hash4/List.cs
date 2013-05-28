using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hash4
{
    public class ListElement
    {
        public int data;
        public ListElement next;
    }

    public class List
    {
        private ListElement head;
        private int length;

        /// <summary>
        /// Creating of a list
        /// </summary>
        public List()
        {
            head = new ListElement();
            head.data = 0;
            head.next = null;
            length = 0;
        }

        /// <summary>
        /// ADding value to the list
        /// </summary>
        /// <param name="value">value</param>
        /// <param name="pos">position</param>
        public void AddToList(int value, ListElement pos)
        {
            ListElement tmp = new ListElement();
            tmp.data = value;
            tmp.next = pos.next;
            pos.next = tmp;
            length++;
        }

        /// <summary>
        /// Deleting from list
        /// </summary>
        /// <param name="pos">position</param>
        public void DeleteFromList(ListElement pos)
        {
            ListElement tmp = this.head;
            if (this.head.next == null)
                return;
            while (tmp.next == null || tmp.next != pos)
            {
                tmp = tmp.next;
            }
            tmp.next = pos.next;
            length--;
        }

        /// <summary>
        /// Returns length of the list
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return length;
        }

        /// <summary>
        /// Returns 
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public int Retrieve(ListElement pos)
        {
            return pos.data;
        }

        public ListElement Next(ListElement pos)
        {
            return pos.next;
        }

        public ListElement First()
        {
            return this.head;
        }

        /// <summary>
        /// Searching element in list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SearchInList(int value)
        {
            ListElement pos = this.First();
            while (pos.next != null)
            {
                if (pos.next.data == value)
                    return true;
                pos = pos.next;
            }
            return false;
        }

        /// <summary>
        /// Printing of a list
        /// </summary>
        public void PrintList()
        {
            ListElement pos = this.First();
            while (pos.next != null)
            {
                Console.Write(Retrieve(pos.next));
                Console.Write(' ');
                pos = pos.next;
            }
            Console.WriteLine();
        }
    }
}
