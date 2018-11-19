using System;
using Name = System.String;
using Greeting = System.String;
using PersonalizedGreeting = System.String;


namespace FunctionalCSharp
{
    public static class MyGreeting
    {
        public static void Do()
        {
            Func<Greeting, Name, PersonalizedGreeting> greet
                = (gr, name) => $"{gr}, {name}";
            Name[] names = {"Tristan", "Ivan"};

            names.Map(g => greet("Hello", g)).ForEach(Console.WriteLine);
            // prints: Hello, Tristan
            // Hello, Ivan}
            Func<Greeting, Func<Name, PersonalizedGreeting>> greetWith = gr => name => $"{gr}, {name}";

            var greetFormally = greetWith("Good evening");
            names.Map(greetFormally).ForEach(Console.WriteLine);
        }

        

    }
}
