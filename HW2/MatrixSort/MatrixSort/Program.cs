using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixSort
{
    class Program
    {
        /// <summary>
        /// Main part of programm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of matrix (horizontal length and vertical length):");
            int hor = int.Parse(Console.ReadLine());
            int vert = int.Parse(Console.ReadLine());
            int[,] matrix = new int[hor, vert];
            Console.WriteLine("Enter the matrix");
            for (int i = 0; i < vert; i++)           
                for (int j = 0; j < hor; j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
            Console.WriteLine("Matrix has been sorted:");
            QMatrixSort(matrix, 0, hor - 1, vert);
            for (int i = 0; i < vert; i++)
            {
                for (int j = 0; j < vert; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Array"></param>
        /// <param name="LeftBorder"></param>
        /// <param name="RightBorder"></param>
        /// <param name="MatrixHorLength"></param>
        static void QMatrixSort(int[,] Array, int LeftBorder, int RightBorder, int MatrixHorLength)
        {
            int LeftElement = LeftBorder;
            int RightElement = RightBorder;
            int mid = Array[(LeftBorder + RightBorder) / 2, 0];
            if (RightBorder > LeftBorder)
            {
                while (LeftElement <= RightElement)
                {
                    while ((LeftElement < RightBorder) && (Array[LeftElement, 0] < mid))
                        LeftElement++;
                    while ((RightElement > LeftBorder) && (Array[RightElement, 0] > mid))
                        RightElement--;
                    if (LeftElement <= RightElement)
                    {
                        
                        for (int j = 0; j < MatrixHorLength; j++)
                        {
                            int tmp;
                            tmp = Array[LeftElement, j];
                            Array[LeftElement, j] = Array[RightElement, j];
                            Array[RightElement, j] = tmp;
                        }
                        LeftElement++;
                        RightElement--;
                    }
                }
                if (LeftBorder < RightElement)
                    QMatrixSort(Array, LeftBorder, RightElement, MatrixHorLength);
                if (LeftElement < RightBorder)
                    QMatrixSort(Array, LeftElement, RightBorder, MatrixHorLength);
            }
        }
    }
}
