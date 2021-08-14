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
        
        public static bool GuidIsEmpty(this Guid id)
        {
            return id == Guid.Empty;
        }
        public static string reverseString(this string Word)
        {
            char[] arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);
            return invertida;
        }
    }
}
