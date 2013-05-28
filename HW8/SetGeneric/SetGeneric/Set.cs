using System.Collections.Generic;
using System.Collections;

namespace SetGeneric
{
    public class Set<T> : IEnumerable<T>
    {
        /// <summary>
        /// Add element in set.
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            if (this.Search(value))
            {
                return;
            }
            list.Insert(index, value);
            index++;
        }

        /// <summary>
        /// True if there is such an element in set
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Search(T value)
        {
            foreach (T x in this.list)
            {
                if (value.Equals(x))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Delete element in set.
        /// </summary>
        /// <param name="value"></param>
        public void Remove(T value)
        {
            if (!this.Search(value))
            {
                throw new Exception();
            }
            this.list.Remove(value);
        }

        /// <summary>
        /// Union of two sets.
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>
        public Set<T> Union(Set<T> set)
        {
            var result = new Set<T>();
            foreach (T x in set)
            {
                result.Add(x);
            }
            foreach (T x in this.list)
            {
                if (!result.Search(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        /// <summary>
        /// Crossing of two sets.
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>
        public Set<T> Crossing(Set<T> set)
        {
            var result = new Set<T>();
            foreach (T x in set)
            {
                if (this.Search(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private List<T> list = new List<T>();
        private int index = 0;
    }
}
