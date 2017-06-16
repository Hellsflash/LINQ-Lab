using System;
using System.Linq;

namespace Bounded_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n >= bounds.Min() && n <= bounds.Max())
                .ToList();

            
            
                Console.WriteLine(string.Join(" ",numbers));
            
        }
    }
}
