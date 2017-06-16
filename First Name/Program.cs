using System;
using System.Linq;

namespace First_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var letters = Console.ReadLine()
                .Split()
                .OrderBy(l=>l);

            foreach (var letter in letters)
            {
               var result = names.Where(w => w.ToLower().StartsWith(letter.ToLower())).FirstOrDefault();

                if (result!=null)
                {
                    Console.WriteLine(result);
                    return;
                }
                
            }
            Console.WriteLine("No match");
        }
    }
}
