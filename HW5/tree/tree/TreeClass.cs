using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tree
{
    public abstract class TreeClass
    {
        /// <summary>
        /// Symbol of the operation
        /// </summary>
        public char Operation { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        public int Number { get; set; }
        
        /// <summary>
        /// Method which counts the right and left branches
        /// </summary>
        /// <returns>Tree value</returns>
        public abstract int CountBranches();

        /// <summary>
        /// Left Branch
        /// </summary>
        public TreeClass LeftBranch { get; set; }

        /// <summary>
        /// Right branch
        /// </summary>
        public TreeClass RightBranch { get; set; }

        /// <summary>
        /// Method which prints the tree
        /// </summary>
        public abstract void PrintNum();
    }
}
