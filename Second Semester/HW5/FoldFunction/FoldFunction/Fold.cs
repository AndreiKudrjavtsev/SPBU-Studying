using System;
using System.Collections.Generic;

namespace FoldFunction
{
    public static class Fold
    {
        T FoldFunction<T>(List<T> list, T initialValue, Func<T, T, T> function)
        {
            foreach (T value in list)
                initialValue = function(initialValue, value);
            return initialValue;
        }
    }
}