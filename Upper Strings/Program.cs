using System;
using System.Linq;

namespace Upper_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            input.Select(w => w.ToUpper())
                .ToList()
                .ForEach(w => Console.Write(w + " "));
            Console.WriteLine();
        }
    }
}
