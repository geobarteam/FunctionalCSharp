using System.Collections.Generic;
using System.Collections.Specialized;
using FunctionalCSharp.Option;


namespace FunctionalCSharp
{
    public static partial class Extensions
    {
        public static Option<T> Some<T>(T value) => new Some<T>(value); // wrap the given value into a Some
        public static None None => None.Default;  // the None value

        public static Option<string> Lookup(this NameValueCollection @this, string key)
            => @this[key];

        public static Option<T> Lookup<K, T>(this IDictionary<K, T> dict, K key)
        {
            T value;
            return dict.TryGetValue(key, out value)
                ? Some(value) : None;
        }
    }
}