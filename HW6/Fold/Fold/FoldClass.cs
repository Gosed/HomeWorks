using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fold
{
    public class FoldClass
    {
        /// <summary>
        /// Fold function
        /// </summary>
        /// <param name="list">List</param>
        /// <param name="BVal">The begining value</param>
        /// <param name="funct">Function</param>
        /// <returns>Result</returns>
        public static int FoldFunct(List<int> list, int BVal, Func<int, int, int> funct)
        {
            for (int i = 0; i < list.Count; i++)
            {
                BVal = funct(BVal, list[i]);
            }
            return BVal;
        }
    }
}
