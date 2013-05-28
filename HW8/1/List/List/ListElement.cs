using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List
{
    public class ListElement<T>
    {
        /// <summary>
        /// Value of this element.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Pointer to next element in list.
        /// </summary>
        public ListElement<T> Next { get; set; }
    }
}
