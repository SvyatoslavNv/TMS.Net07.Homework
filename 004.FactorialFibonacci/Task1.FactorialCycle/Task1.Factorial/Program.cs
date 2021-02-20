using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("enter a number to calculate its factorial: ");
            string input = Console.ReadLine();
            bool resultNumber = int.TryParse(input, out number);
            if (resultNumber)
            {
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine($"factorial {number} = {factorial}");
            }
            else
            {
                Console.Write($"\"{input}\" incorrect input");
            }
            Console.ReadLine();
        }
    }
}
