﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hash4
{
    public class H2 : HashInterface
    {
        public int Hash(int value, int n)
        {
            return value.GetHashCode() % (n - 1);
        }
    }
}
