using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of matrix (horizontal length and vertical length):");
            int hor = int.Parse(Console.ReadLine());
            int vert = int.Parse(Console.ReadLine());
            int[,] matrix = new int[hor, vert];
            Console.WriteLine("Enter the matrix");
            for (int i = 0; i < vert; i++)           
                for (int j = 0; j < vert; j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
            Console.WriteLine("Matrix has been sorted:");
            QMatrixSort(matrix, 0, vert - 1, hor);
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
                        int i;
                        for (int j = 0; j < MatrixHorLength; j++)
                        {
                            i = Array[LeftElement, j];
                            Array[LeftElement, j] = Array[RightElement, j];
                            Array[RightElement, j] = i;
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
