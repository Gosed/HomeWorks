using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace tree
{
    class Program
    {
        /// <summary>
        /// Main part of a programm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CountTree tree = new CountTree();
            StreamReader streamReader = new StreamReader("input.txt");
            string str = "";
            while (!streamReader.EndOfStream)
            {
                str += streamReader.ReadLine();
            }
            int tmp = 0;
            tree.Build(ref tmp, str);
            Console.WriteLine(tree.CountThisTree());
            tree.PrintThisTree();
        }
    }
}
