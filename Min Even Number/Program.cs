﻿using System;
using System.Linq;

namespace Min_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine(
                    $"{Console.ReadLine().Split(' ').Select(double.Parse).Where(n => n % 2 == 0).Min():f2}");
            }
            catch (Exception e)
            {
                Console.WriteLine("No match");
                
            }
        }
    }
}

