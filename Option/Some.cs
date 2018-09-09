using System;

namespace FunctionalCSharp
{
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
}