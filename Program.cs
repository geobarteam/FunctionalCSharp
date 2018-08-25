using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using static System.Linq.ParallelEnumerable;
using System.Text.RegularExpressions;
using FunctionalCSharp.None.Option;


namespace FunctionalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var subs = new Subscriber
            {
                FirstName = new Some<string>("Geoffrey"),
                LastName = "test"

            };
        }
    }

    public class Subscriber
    {
        public Option<string> FirstName { get; set; }

        public string LastName { get; set; }
    }
  


}