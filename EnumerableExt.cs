using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Immutable;
using Unit = System.ValueTuple;

namespace FunctionalCSharp
{
    public static class EnumerableExt
    {
        public static IEnumerable<Unit> ForEach<T>
            (this IEnumerable<T> ts, Action<T> action)
            => ts.Map(action.ToFunc()).ToImmutableList();
    }
}
