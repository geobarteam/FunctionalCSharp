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
using static FunctionalCSharp.F;
using static System.Math;


namespace FunctionalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrate use of Match with Option type
            /* Example 1 - Otion Type
            Console.WriteLine(OptionExamples.GreetingFor(new Subscriber()));
            */
            
            /* Example 2 - Map
            
            var opt = Some("Geoffrey");
            opt.Map(F.ToUpper)
                .Map(o => $"Hello {o},")
                .ForEach(n => Console.WriteLine(n));
           
            do
            {
                AskForValidAgeAndPrintFlatteringMessage.Start();
            } while (true);*/

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