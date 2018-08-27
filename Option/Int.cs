using System;
using static FunctionalCSharp.F;


namespace FunctionalCSharp
{
    public static class Int
    {
        public static Option<int> Parse(string s)
        {
            int result;
            return int.TryParse(s, out result) ? Some(result) : None;
        }
    }

    public static class Enum
    {
        public static Option<T> Parse<T>(string s) where T : struct
        {
           T result;
           return System.Enum.TryParse(s, out result) ? Some(result) : None;



        }
    }
}
