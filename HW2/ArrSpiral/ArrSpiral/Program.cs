using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrSpiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of matrix:");
            int n = int.Parse(Console.ReadLine()); 
            int[,] array = new int[n,n];
            Console.WriteLine("Enter matrix:");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Spiral is:");
            SpiralArray(array, n);
            Console.ReadKey();
        }
        static void SpiralArray(int[,] Array, int N)
        {
            int hor = N / 2;
            int vert = N / 2;
            int step = 2;
            int[] kvert = new int[4];
            int[] khor = new int[4];
            kvert[0] = 0;
            kvert[1] = 1;
            kvert[2] = 0;
            kvert[3] = -1;
            khor[0] = 1;
            khor[1] = 0;
            khor[2] = -1;
            khor[3] = 0;
            for (int i = 0; i < N / 2; i++)
            {
                hor++;
                for (int j = 0; j <= 3; j++)
                {
                    for (int k = 1; k <= step; k++)
                    {
                        Console.Write(Array[hor,vert]);
                        hor = hor + khor[j];
                        vert = vert + kvert[j];
                    }
                }
            }
        }
    }
}
