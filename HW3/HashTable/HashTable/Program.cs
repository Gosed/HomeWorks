using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable HashTab = new HashTable(55);            
            int tmp = 0;
            string line = "nothing";
            while ((tmp == 1) || (tmp == 2) || (tmp == 3))
            {
                Console.WriteLine("Enter: 1 - add; 2 - find; 3 - delete.");
                tmp = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a word: ");
                line = Console.ReadLine();
                if (tmp == 1)       
                    HashTab.AddToHashTable(line);
                if (tmp == 2)
                    if (HashTab.FindInHashTable(line))
                        Console.WriteLine("Exist");
                    else
                        Console.WriteLine("Doesn't exist");
                if (tmp == 3)
                    HashTab.DeleteFromHashTable(line);
            }
        }
    }
}
