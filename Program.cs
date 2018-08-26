using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using static System.Linq.ParallelEnumerable;
using System.Text.RegularExpressions;
using FunctionalCSharp.Option;
using FunctionalCSharp.Option;


namespace FunctionalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrate use of Match with Option type
            Console.WriteLine(OptionExamples.GreetingFor(new Subscriber()));
            var a = Int.Parse("10");
            var t = new NameValueCollection().Lookup("green");
            Console.WriteLine(t.Match(
                () => "T is None",
                (value) => $"T is {value}"));
            Console.ReadLine();
        }

        
        
    }

   
  


}