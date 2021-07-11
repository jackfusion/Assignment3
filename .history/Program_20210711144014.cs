using System;
using static System.Console;
//using Serilog;

namespace Assignment3
{
    class Program
    {
        public static string primeFactors(int number)
        {
            int _number = number;
            string str = "";

            for (int div = 2; div <= number; div++)
            {
                int x = 0;
                while (number % b == 0)
                {
                    str += div + " ";
                    number = number / div;
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
