﻿using System;
using static System.Console;
using System.Collections.Generic;
//using Serilog;

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
                    //str += div + " ";
                    primes.Add(div);
                    number = number / div;
                }
            }

            return string.Join(" x ", primes);
        }
        static void Main(string[] args)
        {
            WriteLine(primeFactors(4));
            WriteLine(primeFactors(7));
            WriteLine(primeFactors(30));
            WriteLine(primeFactors(40));
            WriteLine(primeFactors(50));
        }
    }
}
