using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Result: ");
            Console.Write(Fibbonachi(n));
            Console.ReadKey();
        }
        /// <summary>
        /// Count Fibbonachi
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>Fibbonachi</returns>
        public static int Fibbonachi(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return Fibbonachi(n - 1) + Fibbonachi(n - 2);
        }
    }

}