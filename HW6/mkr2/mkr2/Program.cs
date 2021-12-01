using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
namespace mkr2
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string> {"green", "brown", "blue", "red",};
            var query = colors.Where(c => c.Length <= 4);
            Console.WriteLine(query.Count());
            colors.Add("red");
            Console.WriteLine(query.Count());
            colors.Add("red");
            Console.WriteLine((query.Count()));

        }
    }
}