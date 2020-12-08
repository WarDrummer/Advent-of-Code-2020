using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int n)
        {
            var enumerable = source as T[] ?? source.ToArray();
            return enumerable.Skip(Math.Max(0, enumerable.Count() - n));
        }
    }
}