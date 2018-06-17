using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
             Enumerable.Zip(
                new[] {1, 2, 3},
                new[] {"ichi", "ni", "san"},
                (number, name) => $"In Japanese {number} is: {name}")
                .ToList().ForEach(Console.WriteLine);
            
            
           
        }
    }

    static class StringExt 
    {   
        public static string ToSentenceCase(this string s)      
            => s.ToUpper()[0] + s.ToLower().Substring(1); 

        
    }
 
    public class ListFormatter 
    {   
        int counter;
    
        string PrependCounter(string s) => $"{++counter}. {s}"; 
    
        public List<string> Format(List<string> list) 
             => list.AsParallel()
                .Select(StringExt.ToSentenceCase)
                .Select(PrependCounter).ToList(); 
    
    }
}
