using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniqueList
{
    class UniqueList : List
    {
        /// <summary>
        /// True if element exist in list
        /// </summary>
        /// <param name="el">Element</param>
        /// <returns>Element's existion</returns>
        public bool ElementExist(int el)
        {
            if (ListIsEmpty())
                return false;
            if (this.head.Data == el)
                return true;
            ListElement iterator = this.head;
            while ((iterator.Next != null) && (iterator.Next.Data != el))
            {
                iterator = iterator.Next;
            }
            if (iterator.Next == null)                
                return false;
            return true;
        }

        /// <summary>
        /// Method adds element to the list
        /// </summary>
        /// <param name="el">Element</param>
        public void AddToList(int el)
        {
            if (ElementExist(el))
                return;
            if (ListIsEmpty())
            {
                this.head = new ListElement(el);
                return;
            }
            ListElement iterator = this.head;
            while (iterator.Next != null)
            {
                iterator = iterator.Next;
            }
            ListElement tmp = new ListElement(el);
            iterator.Next = tmp;
        }

        /// <summary>
        /// Method deletes element from list
        /// </summary>
        /// <param name="el">Element</param>
        public void DeleteFromList(int el)
        {
            if (!ElementExist(el))
                throw new Exception("There is no such element in list!!!");
            if (this.head.Data == el)
            {
                this.head = this.head.Next;
                return;
            }
            ListElement iterator = this.head;
            while ((iterator.Next != null) && (iterator.Next.Data != el))
            {
                iterator = iterator.Next;
            }
            iterator.Next = iterator.Next.Next;
        }
    }
}
