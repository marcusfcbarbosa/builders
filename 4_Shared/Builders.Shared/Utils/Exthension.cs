using System;
using System.Collections.Generic;

namespace Builders.Shared.Utils
{
    public static class Exthension
    {

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T element in source)
                action(element);
        }
        public static int ForEach<T>(this IEnumerable<T> list, Action<int, T> action)
        {
            if (action == null) throw new ArgumentNullException("action");

            var index = 0;

            foreach (var elem in list)
                action(index++, elem);

            return index;
        }
    }
}
