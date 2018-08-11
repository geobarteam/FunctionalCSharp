using System;
using System.Diagnostics;
using System.IO;
using Unit = System.ValueTuple;

namespace FunctionalCSharp
{
    public static class Instrumentation
    {
        public static void Time(string op, Action act)
            => Time<Unit>(op, act.ToFunc());

        public static T Time<T>(string op, Func<T> f)
        {
            var sw = new Stopwatch();
            sw.Start();
            T t = f();
            sw.Stop();
            Console.WriteLine($"{op} took {sw.ElapsedMilliseconds}ms");
            return t;
        }

        public static class UnitExample
        {
            public static void Do()
            {
                Instrumentation.Time("Write File", () => File.AppendAllText("test.txt", "Hello World!"));
            }
        }
    }
}