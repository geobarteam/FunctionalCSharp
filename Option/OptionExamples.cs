using System;
using System.Collections.Generic;
using System.Text;
using FunctionalCSharp.Option;

namespace FunctionalCSharp.Option
{
    public static class OptionExamples
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
