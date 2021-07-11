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

            for (b = 2; a > 1; b++)
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
            WriteLine(primeFactors(4));
        }
    }
}
