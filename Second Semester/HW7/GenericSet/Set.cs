using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSet
{
    public class Set<T>
    {
        public List<T> elementSet = new List<T>();

        /// <summary>
        /// method, checks emptiness of set
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return elementSet.Count == 0;
        }

        /// <summary>
        /// method, checks contains element in set or not
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool IsContains(T element)
        {
            return elementSet.Contains(element);
        }

        /// <summary>
        /// method for adding element in set
        /// </summary>
        /// <param name="element"></param>
        public void AddElement(T element)
        {
            if (IsContains(element))
                return;
            else
                elementSet.Add(element);
        }

        /// <summary>
        /// method for deleting element from set
        /// </summary>
        /// <param name="element"></param>
        public void DeleteElement(T element)
        {
            elementSet.Remove(element);
        }

        /// <summary>
        /// method for union operation for two sets
        /// </summary>
        /// <param name="set"> second operand </param>
        /// <returns></returns>
        public Set<T> SetUnion(Set<T> set)
        {
            Set<T> newSet = new Set<T>();
            newSet.elementSet = elementSet;
            foreach (T value in set.elementSet)
            {
                newSet.AddElement(value);
            }
            return newSet;
        }

        /// <summary>
        /// method for intersection operation for two sets
        /// </summary>
        /// <param name="set"> second operand </param>
        /// <returns></returns>
        public Set<T> SetIntersection(Set<T> set)
        {
            Set<T> newSet = new Set<T>();
            foreach (T value in set.elementSet)
            {
                if (IsContains(value))
                {
                    newSet.AddElement(value);
                }
            }
            return newSet;
        }
    }
}
