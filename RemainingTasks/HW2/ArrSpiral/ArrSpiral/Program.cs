using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrSpiral
{
    public class Program
    {
        /// <summary>
        /// main part of the program
        /// </summary>
        /// <param name="args"></param>
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
            int[] resultArray = new int[n*n];
            SpiralArray(array, n, resultArray);
            for (int i = 0; i < n * n; i++)
                Console.WriteLine(resultArray[i]);
            Console.ReadKey();
        }

        /// <summary>
        /// Method which get an array of spiral
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <param name="resArray"></param>
        public static void SpiralArray(int[,] array, int n, int[] resArray)
        {
            int xPos = n / 2;
            int yPos = n / 2;
            int rescount = 0;
            resArray[rescount] = array[yPos, xPos];
            int roundnumber = n / 2;
            int[] xChange = new int[4];
            int[] yChange = new int[4];
            xChange[0] = 0; yChange[0] = 1;
            xChange[1] = -1; yChange[1] = 0;
            xChange[2] = 0; yChange[2] = -1;
            xChange[3] = 1; yChange[3] = 0;
            int stepsNum = 2;
            for (int i = 0; i < roundnumber; i++)
            {
                xPos++;
                yPos--;
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < stepsNum; k++)
                    {
                        xPos += xChange[j];
                        yPos += yChange[j];
                        rescount++;
                        resArray[rescount] = array[yPos, xPos];
                    }
                stepsNum += 2;
            }
        }
    }
}
