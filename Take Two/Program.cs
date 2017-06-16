using System;
using System.Linq;

namespace Take_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            number.Where(n => 10 <= n && n <= 20)
                .Distinct()
                .Take(2)
                .ToList()
                .ForEach(n => Console.Write(n + " "));
            Console.WriteLine();
        }

    }
}
