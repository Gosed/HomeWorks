using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tree
{
    public class Substruction : OperationClass
    {
        /// <summary>
        /// Substructing of a left and right branches
        /// </summary>
        /// <returns>Result</returns>
        public override int CountBranches()
        {
            return this.LeftBranch.CountBranches() - this.RightBranch.CountBranches();
        }

        /// <summary>
        /// Printing of a  "-"
        /// </summary>
        public override void PrintOperation()
        {
            Console.Write("-");
        }
    }
}
