using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public partial class Extensions
    {
        public static Option<R> Bind<T, R>
            (this Option<T> optT, Func<T, Option<R>> f)
            => optT.Match(
                () => None,
                (t) => f(t));
                
        public static Option<R> Map<T, R>
            (this Option<T> optT, Func<T, R> f)
            => optT.Match(
                () => None,
                (t) => Some(f(t)));
    }
}
