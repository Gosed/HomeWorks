﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class StackElement<T>
    {
        /// <summary>
        /// Pointer to next element in stack.
        /// </summary>
        public StackElement<T> Next { get; set; }

        /// <summary>
        /// Value of this element in stack.
        /// </summary>
        public T Value { get; set; }
    }
}
