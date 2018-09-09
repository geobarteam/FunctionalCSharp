using FunctionalCSharp.Option;
using System;

namespace FunctionalCSharp
{
    public struct Option<T>
    {
        readonly bool isSome;
        readonly T value;
        private Option(T value)
        {
            this.isSome = true;
            this.value = value;
        }

        public static implicit operator Option<T>(None _)
            => new Option<T>();
        public static implicit operator Option<T>(Some<T> some)
            => new Option<T>(some.Value);

        public static implicit operator Option<T>(T value)
            => value == null ? new None() : new Option<T>(value);   
       
        public R Match<R>(Func<R> None, Func<T, R> Some)
            => isSome ? Some(value) : None();
    }
}