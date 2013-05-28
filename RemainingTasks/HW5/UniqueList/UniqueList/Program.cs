using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniqueList
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueList list = new UniqueList();
            list.AddToList(4);
          //  Console.WriteLine(list.ListIsEmpty());
            Console.WriteLine(list.ElementExist(4));
      //      list.Print();
    //        Console.WriteLine(list.SizeOfList());
       //     list.DeleteFromList(4);
        //    Console.WriteLine(list.ElementExist(4));
          // list.Print();
  //         Console.WriteLine(list.SizeOfList());
            Console.WriteLine(list.ElementExist(4));
            list.AddToList(5);
            Console.WriteLine(list.ElementExist(5));
            list.Print();
           // Console.WriteLine(list.SizeOfList());
    //        list.DeleteFromList(5);
      //      Console.WriteLine(list.ElementExist(4));
        //    list.Print();
            Console.WriteLine(list.SizeOfList());
            Console.WriteLine(list.DataFromPos(2));
            Console.ReadKey();
        }
    }
}
