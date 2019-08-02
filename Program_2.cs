using System;
using System.Linq;
using System.Collections.Generic;

namespace Explorer
{
    class Program
    {
        // https://projecteuler.net/problem=2
        static IEnumerable<long> Fibonacci () 
        {
            long f0 = 0;
            long f1 = 1;
            long f;
            while (true)
            {
                f = f0 + f1;
                yield return f;
                f0 = f1;
                f1 = f;
            }
            
        }
        static void Main()
        {
            long sum = Fibonacci().TakeWhile(n => n < 4000000L).Where(n => n % 2 == 0).Sum();

            Console.WriteLine("Sum: " + sum);
        }


    }
       
        
}

