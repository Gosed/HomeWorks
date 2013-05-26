using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalc
{
    interface StackInterface
    {
        void Push(int num);
        int Top();
        int Pop();
    }
}
