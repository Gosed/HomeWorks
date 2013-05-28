using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tree
{
    public class CountTree
    {
        /// <summary>
        /// Head of the tree
        /// </summary>
        public TreeClass head { get; set; }

        /// <summary>
        /// Type of the opration
        /// </summary>
        /// <param name="Operation">Operation</param>
        /// <returns>Type of the Operation</returns>
        private TreeClass OperationType(char operation)
        {
            if (operation == '+')
                return new Summ();
            if (operation == '-')
                return new Substruction();
            if (operation == '*')
                return new Multiplication();
            if (operation == '/')
                return new Division();
            return new NumberClass();
        }

        /// <summary>
        /// Building of a tree
        /// </summary>
        /// <param name="i">Index to build(0 - default)</param>
        /// <param name="str">String to read</param>
        public void Build(ref int i, string str)
        {
            TreeClass tmp = new Summ();
            while ((i < str.Length) && ((str[i] == ' ') || (str[i] == ')')))
                i++;
            if ((str[i] == '+') || (str[i] == '-') || (str[i] == '/') || (str[i] == '*'))
            {
                tmp = OperationType(str[i]);
                tmp.Operation = str[i];
                tmp.Number = -1;
                i++;
            }
            if ((i < str.Length) && (str[i] == '('))
            {
                CountTree LTree = new CountTree();
                i++;
                LTree.Build(ref i, str);
                CountTree RTree = new CountTree();
                i++;
                RTree.Build(ref i, str);
                tmp.LeftBranch = LTree.head;
                tmp.RightBranch = RTree.head;
            }
            int j = i;
            int number = 0;
            while ((j < str.Length) && ((int)str[j] - (int)'0') < 10 && ((int)str[j] - (int)'0') >= 0)
            {

                number = (number * 10) + (int)str[j] - (int)'0';
                j++;
            }
            if (number != 0)
            {
                tmp = OperationType(str[i]);
                i = j;
                tmp.Number = number;
                tmp.Operation = 'x';
            }
            this.head = tmp;
        }

        /// <summary>
        /// Method which counts the tree
        /// </summary>
        /// <returns>Value of the tree</returns>
        public int CountThisTree()
        {
            return this.head.CountBranches();
        }

        /// <summary>
        /// Method which prints the tree
        /// </summary>
        public void PrintThisTree()
        {
            this.head.PrintNum();
        }
    }
}
