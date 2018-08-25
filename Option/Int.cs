﻿using static FunctionalCSharp.F;


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
}
