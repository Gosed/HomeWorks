using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filter
{
    public class Filter
    {
        /// <summary>
        /// Filter function
        /// </summary>
        /// <param name="list">List</param>
        /// <param name="funct">Boolean function with integer parameter</param>
        /// <returns>Changed boolean function</returns>
        public static List<int> FFunction(List<int> list, Func<int, bool> funct)
        {
            List<int> tmp = new List<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                if (funct(list[i]))
                {
                    tmp.Add(list[i]);
                }
            }
            return tmp;
        }
    }
}
