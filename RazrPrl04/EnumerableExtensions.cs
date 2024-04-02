using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazrPrl04
{
    internal static class EnumerableExtensions
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> values, Func<T, bool> predicate)
        {
            foreach (var value in values)
            {
                if (predicate(value)) yield return value;
            }
        }
    }
}
