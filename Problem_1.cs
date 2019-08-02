using System;
using System.Linq;
using System.Collections.Generic;

namespace Explorer
{
    class Program
    {
        // https://projecteuler.net/problem=1
        static void Main()
        {
            int sum = Enumerable.Range(1, 999).Where(n => n % 3 == 0 || n % 5 == 0).Sum();

            Console.WriteLine("sum: " + sum);
        }


    };
       
        
}

