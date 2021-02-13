using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.FactorialRecurs
{
    class Program
    {
        static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.Write("enter a number to calculate its factorial: ");
            string input = Console.ReadLine();
            bool resultNumber = int.TryParse(input, out number);
            if (resultNumber)
            {
                Console.WriteLine($"factorial {number} = {Factorial(number)}");
            }
            else
            {
                Console.Write($"\"{input}\" incorrect input");
            }
            Console.ReadLine();
        }
    }
}
