using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.FibonacciRecurs
{
    class Program
    {
        static int Fibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.Write("enter a number to calculate its fibonacci: ");
            string input = Console.ReadLine();
            bool resultNumber = int.TryParse(input, out number);
            if (resultNumber)
            {
                Console.WriteLine($"fibonacci {number} = {Fibonacci(number)}");
            }
            else
            {
                Console.Write($"\"{input}\" incorrect input");
            }
            Console.ReadLine();
        }
    }
}
