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
            Console.Write("! = ");
            Console.Write(Factorial(n));
            Console.ReadKey();
        }
        /// <summary>
        /// Count factorial
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>Factorial</returns>
        public static int Factorial(int n)
        {
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                k = i * k;
            }
            return k;
        }
    }

}
