using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.FibonacciRecursOptim
{
    class Program
    {
        static int Fibonacci(int i, int f1, int f2, int number)
        {
            if (i >= number)
            {
                return f1;
            }
            else
            {
                return Fibonacci(i + 1, f2, f1 + f2, number);
            }
        }

        static int Fibonacci(int number)
        {
            int f1;
            int f2 = 0;
            int f3 = 1;
            for (int i = 0; i < number; i++)
            {
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
            }
            return f2;
        }

        static void Main(string[] args)
        {
            int number;
            Console.Write("enter a number to calculate its fibonacci: ");
            string input = Console.ReadLine();
            bool resultNumber = int.TryParse(input, out number);
            if (resultNumber)
            {
                Console.WriteLine($"fibonacci {number} = {Fibonacci(0, 0, 1, number)} (Recurs)");
                Console.WriteLine($"fibonacci {number} = {Fibonacci(number)} (Cycle)");
            }
            else
            {
                Console.Write($"\"{input}\" incorrect input");
            }
            Console.ReadLine();
        }
    }
}
