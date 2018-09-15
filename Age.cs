using System;
using System.Collections.Generic;
using System.Text;
using static FunctionalCSharp.Extensions;
using static System.Console;

namespace FunctionalCSharp
{
    public struct Age
    {
        public int Value { get; }

        public static Option<Age> Of(int age)
             => IsValid(age) ? Some(new Age(age)) : None;

        private Age(int value)
        {
            if (!IsValid(value))
                throw new ArgumentException($"{value} is not a valid age");
            Value = value;
        }

        private static bool IsValid(int age)
            => 0 <= age && age <= 120;
    }

    public static class AskForValidAgeAndPrintFlatteringMessage
    {
        public static void Start()
            => WriteLine($"Only {ReadAge()}! That's young!");
        static Age ReadAge()
            => ParseAge(Prompt("Please enter your age"))
                .Match(
                    () => ReadAge(),
                    (age) => age);
        static Option<Age> ParseAge(string s)
            => Int.Parse(s).Bind(Age.Of);
        static string Prompt(string prompt)
        {
            WriteLine(prompt);
            return ReadLine();
        }
    }
}
