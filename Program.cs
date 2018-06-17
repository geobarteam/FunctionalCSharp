using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingList = new List<string> { "coffee beans", "BANANAS", "Dates" };

            var largeList = Enumerable.Range(1, 100000);

            new ListFormatter().Format(largeList.Select(i=>i.ToString()).ToList()).ForEach(Console.WriteLine);
           
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
             => list.Select(StringExt.ToSentenceCase).AsParallel()
                .Select(PrependCounter).ToList(); 
    
    }
}
