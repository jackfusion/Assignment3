using System;
using static System.Console;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        public static string primeFactors(int number)
        {
            var primes = new List<int>();

            for (int div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;
                }
            }

            return string.Join(" x ", primes);
        }
        static void Main(string[] args)
        {
            int[] list = new int[] { 4, 7, 30, 40, 50 };

            for (int a; a <= list.Length; a++)
            {
                WriteLine($"Prime factors of {list} are " + primeFactors(4));
                a++;
            }
                
            WriteLine(primeFactors(7));
            WriteLine(primeFactors(30));
            WriteLine(primeFactors(40));
            WriteLine(primeFactors(50));
        }
    }
}
