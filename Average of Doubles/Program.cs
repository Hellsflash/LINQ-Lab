using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            var avarage =numbers.Sum()/numbers.Count;
            Console.WriteLine($"{avarage:f2}");
        }
    }
}
