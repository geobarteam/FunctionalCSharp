using FunctionalCSharp.Option;
using System;

namespace FunctionalCSharp
{

    public static partial class F
    {
        public static Option<T> Some<T>(T value) => new Some<T>(value); // wrap the given value into a Some
        public static None None => None.Default;  // the None value
    }

    public struct Some<T>
    {
        internal T Value { get; }
        public Some(T value)
        {
            if (value == null)
                throw new ArgumentNullException();
            Value = value;
        }
    }

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