using System;
using System.Linq;

namespace Find_and_Sum_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var sum = input
                .Split(' ')
                .Select(w =>
                {
                    long value;
                    bool success = long.TryParse(w, out value);
                    return new {value, success};
                })
                .Where(s => s.success)
                .Select(n => n.value)
                .ToList()
                .Sum();

            Console.WriteLine(sum);
        }
    }
}
