using System;
using System.Collections;
using System.Collections.Generic;

namespace MapFunction
{
    public static class Map
    {
        List<T> MapFunction<T>(List<T> list, Func<T, T> function)
        {
            List<T> newList = new List<T>();
            foreach (T value in list)
            {
                newList.Add(function(value));
            }
            return newList;
        }
    }
}
