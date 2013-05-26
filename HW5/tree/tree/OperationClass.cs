using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tree
{
    public abstract class OperationClass : TreeClass
    {
        /// <summary>
        /// Printing of some symbol
        /// </summary>
        public abstract void PrintOperation();

        /// <summary>
        /// Printing of a tree
        /// </summary>
        public override void PrintNum()
        {
            Console.Write('(');
            this.LeftBranch.PrintNum();
            this.PrintOperation();
            this.RightBranch.PrintNum();
            Console.Write(')');
        }
    }
}
