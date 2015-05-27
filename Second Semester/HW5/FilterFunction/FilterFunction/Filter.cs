using System;
using System.Collections.Generic;

namespace FilterFunction
{
    public static class Filter
    {
        public static List<T> FilterFunction<T>(List<T> list, Func<T, bool> filter)
        {
            List<T> newList = new List<T>();
            foreach (T value in list)
            {
                if (filter(value))
                    newList.Add(value);
            }
            return newList;
        }
    }
}
