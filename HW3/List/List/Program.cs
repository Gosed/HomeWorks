using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            PointerList list = new PointerList();
            list.Add(6);
            list.Add(7);
            list.Delete(6);
            list.Print();
        }

    }
}
