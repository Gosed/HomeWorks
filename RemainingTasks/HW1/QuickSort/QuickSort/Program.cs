using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    public class Program
    {
        /// <summary>
        /// Main part of programm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of massive:");
            int[] array = new int[N];
            for (int i = 0; i <= N-1; i++)
                array[i] = int.Parse(Console.ReadLine());
            QSort(array, 0, N-1);
            Console.WriteLine("Massive has been sorted::");
            for (int i = 0; i <= N-1; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Quick Sort
        /// </summary>
        /// <param name="Array">our array</param>
        /// <param name="LeftBorder">left border of array</param>
        /// <param name="RightBorder">right border of array</param>
        public static void QSort(int[] Array, int LeftBorder, int RightBorder)
        {
            int LeftElement = LeftBorder;
            int RightElement = RightBorder;
            int mid = Array[(LeftBorder + RightBorder) / 2];
            if (RightBorder > LeftBorder)
            {
                while (LeftElement <= RightElement)
                {
                    while ((LeftElement < RightBorder) && (Array[LeftElement] < mid))
                        LeftElement++;
                    while ((RightElement > LeftBorder) && (Array[RightElement] > mid))
                        RightElement--;
                    if (LeftElement <= RightElement)
                    {
                        int i;
                        i = Array[LeftElement];
                        Array[LeftElement] = Array[RightElement];
                        Array[RightElement] = i;
                        LeftElement++;
                        RightElement--;
                    }
                }
                if (LeftBorder < RightElement)
                    QSort(Array, LeftBorder, RightElement);
                if (LeftElement < RightBorder)
                    QSort(Array, LeftElement, RightBorder);
            }
        }
    }
}
