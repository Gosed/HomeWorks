using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    /// <summary>
    /// Map function
    /// </summary>
    public class MapFunction
    {
        public static List<int> MFunction(List<int> list, Func<int, int> func)
        {
            List<int> tmp = new List<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                tmp.Add(func(list[i]));
            }
            return tmp;
        }
    }
}
