using System;
using System.IO;
using System.Text;
using Unit = System.ValueTuple;

namespace FunctionalCSharp
{
    using static F;
    public static partial class F
    {
        public static Unit Unit() => default(Unit);
    }

    public static class ActionExt
    {
        public static Func<Unit> ToFunc(this Action action)
            => () => { action(); return Unit(); };
        public static Func<T, Unit> ToFunc<T>(this Action<T> action)
            => (t) => { action(t); return Unit(); };
        // more overloads to cater for Action's with more arguments...
    }
    
}
