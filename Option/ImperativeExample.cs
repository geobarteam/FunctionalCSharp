using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace FunctionalCSharp.Imperative
{
    public static class ImperativeExample
    {
        public static string GreetingFor(Subscriber subscriber)
        {
            if (subscriber.Name == null)
            {
                return "Dear Subscriber,";
            }
            else
            {
                return $"Dear {subscriber.Name},";
            }
        }
    }

    public class Subscriber
    {
        public string Name { get; set; }

        public string Email { get; set; }
    }
}