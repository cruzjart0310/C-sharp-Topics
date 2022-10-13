using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.App
{
    public static class Extensions
    {
        public static bool ContainDuplicates<T>(this IEnumerable<T> enumerable)
        {
            HashSet<T> elements = new HashSet<T>();

            foreach (T item in enumerable)
            {
                if (!elements.Add(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
