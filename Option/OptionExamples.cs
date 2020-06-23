using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using FunctionalCSharp.Option;
using FunctionalCSharp;
using Unit = System.ValueTuple;

namespace FunctionalCSharp.Option
{
    public static class OptionExample
    {
        public static string GreetingFor(Subscriber subscriber)
            => subscriber.Name.Match(
                () => "Dear Subscriber,",
                (name) => $"Dear {name},");

    }

    public class Subscriber
    {
        public Option<string> Name { get; set; }

        public string Email { get; set; }
    }
}
