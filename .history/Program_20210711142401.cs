using System;
using static System.Console;
using Serilog;

namespace Assignment3
{
    class Program
    {
        public static string primeFactors(int number)
        {
            int b;
            int_number = number;
            string str = "";

            for (b = 2; b <= _number; b++)
            {
                if (_number  % b == 0)
                {
                    str += b;
                }
            }

            return string.Join(", ", str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
