using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixSort
{
    public class Program
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
            for (int i = 0; i < hor; i++)           
                for (int j = 0; j < vert; j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
            Console.WriteLine("Matrix has been sorted:");
            QMatrixSort(matrix, 0, vert - 1, hor);
            for (int i = 0; i < hor; i++)
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
        /// Sort of the matrix (QSort from the dirst home work was used)
        /// </summary>
        /// <param name="Array"></param>
        /// <param name="LeftBorder"></param>
        /// <param name="RightBorder"></param>
        /// <param name="MatrixHorLength"></param>
        public static void QMatrixSort(int[,] Array, int LeftBorder, int RightBorder, int MatrixHorLength)
        {
            int LeftElement = LeftBorder;
            int RightElement = RightBorder;
            int mid = Array[0, (LeftBorder + RightBorder) / 2];
            if (RightBorder > LeftBorder)
            {
                while (LeftElement <= RightElement)
                {
                    while ((LeftElement < RightBorder) && (Array[0, LeftElement] < mid))
                        LeftElement++;
                    while ((RightElement > LeftBorder) && (Array[0, RightElement] > mid))
                        RightElement--;
                    if (LeftElement <= RightElement)
                    {
                        
                        for (int i = 0; i < MatrixHorLength; i++)
                        {
                            int tmp;
                            tmp = Array[i, LeftElement];
                            Array[i, LeftElement] = Array[i, RightElement];
                            Array[i, RightElement] = tmp;
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
