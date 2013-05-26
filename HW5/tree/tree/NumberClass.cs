using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tree
{
    public class NumberClass : TreeClass
    {
        /// <summary>
        /// Printing of a value
        /// </summary>
        public override void PrintNum()
        {
            Console.Write(' ');
            Console.Write(Number);
            Console.Write(' ');
        }
        /// <summary>
        /// Returns value
        /// </summary>
        /// <returns>Value</returns>
        public override int CountBranches()
        {
            return (this.Number);
        }
    }
}
