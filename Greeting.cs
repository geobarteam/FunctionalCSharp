using System;
using Name = System.String;
using Greeting = System.String;
using PersonalizedGreeting = System.String;


namespace FunctionalCSharp
{
    class Greeting
    {
        public void Do()
        {
            Func<string, Name, PersonalizedGreeting> greet
                = (gr, name) => $"{gr}, {name}";
            Name[] names = {"Tristan", "Ivan"};

            names.Map(g => greet("Hello", g)).ForEach(Console.WriteLine);
            // prints: Hello, Tristan
            // Hello, Ivan}
        }

        

    }
}
