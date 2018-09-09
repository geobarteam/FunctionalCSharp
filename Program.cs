using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Linq.ParallelEnumerable;
using System.Text.RegularExpressions;
using FunctionalCSharp.Option;
using static FunctionalCSharp.Extensions;
using Unit = System.ValueTuple;


namespace FunctionalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Demonstrate use of Match with Option type
            Console.WriteLine(OptionExamples.GreetingFor(new Subscriber()));
            var a = Int.Parse("10");
            var dayOfWeek = Enum.Parse<DayOfWeek>("Freeday");

            var t = new NameValueCollection().Lookup("green");
            Console.WriteLine(t.Match(
                () => "T is None",
                (value) => $"T is {value}"));
            dayOfWeek = Enum.Parse<DayOfWeek>("Friday");
            

            var numbers = new []{1,2,3,4,5};
            var strings = numbers.Map(n => n.ToString());

            strings.ToList().ForEach(n => Console.Write(n));

            strings.ForEach(n => Console.Write(n));
            */
            var opt = Some("Geoffrey");
            opt.Map(F.ToUpper)
                .Map(o => $"Hello {o},")
                .ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
    }

    public static partial class F
    {
        public static IEnumerable<R> Map<T, R>
            (this IEnumerable<T> ts, Func<T, R> f)
        {
            foreach (var t in ts)
                yield return f(t);
        }

        
        public static Option<Unit> ForEach<T>
            (this Option<T> opt, Action<T> action)
            => Extensions.Map(opt, action.ToFunc());

        public static String ToUpper(String s)
        {
            return s.ToUpper();
        }

    }

   
  


}