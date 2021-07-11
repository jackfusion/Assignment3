using System;
using static System.Console;
//using Serilog;

namespace Assignment3
{
    class Program
    {
        public static string primeFactors(int number)
        {
            int b;
            int _number = number;
            string str = "";

            for (b = 2; number > 1; b++)
            {
                int x = 0;
                while (number % b == 0)
                {
                    number /= b;
                    x++;
                }
            }

            return string.Join(", ", str);
        }
        static void Main(string[] args)
        {
            WriteLine(primeFactors(4));
        }
    }
}
